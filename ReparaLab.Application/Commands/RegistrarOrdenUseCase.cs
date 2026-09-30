using System.Globalization;
using ReparaLab.Application.Common;
using ReparaLab.Application.DTOs;
using ReparaLab.Domain.Builders;
using ReparaLab.Domain.Entities;
using ReparaLab.Domain.Enums;
using ReparaLab.Domain.Exceptions;
using ReparaLab.Domain.Interfaces;
using ReparaLab.Domain.Notificaciones;
using ReparaLab.Domain.Planes;
using ReparaLab.Domain.Prototypes;

namespace ReparaLab.Application.Commands;

public class RegistrarOrdenUseCase
{
    private readonly IOrdenRepository _repositorio;
    private readonly CatalogoPlantillas _plantillas;
    private readonly IEnumerable<IFabricaPlan> _fabricasPlan;
    private readonly IEnumerable<CreadorNotificador> _creadoresNotificador;
    private readonly IBitacora _bitacora;

    public RegistrarOrdenUseCase(
        IOrdenRepository repositorio,
        CatalogoPlantillas plantillas,
        IEnumerable<IFabricaPlan> fabricasPlan,
        IEnumerable<CreadorNotificador> creadoresNotificador,
        IBitacora bitacora)
    {
        _repositorio = repositorio;
        _plantillas = plantillas;
        _fabricasPlan = fabricasPlan;
        _creadoresNotificador = creadoresNotificador;
        _bitacora = bitacora;
    }

    public ResultadoOperacion Ejecutar(RegistrarOrdenRequest request)
    {
        if (!CatalogoOpciones.IntentarConvertir(request.Equipo, out TipoEquipo equipo))
            return OpcionNoPermitida("Equipo", CatalogoOpciones.Equipos);

        if (!CatalogoOpciones.IntentarConvertir(request.Servicio, out TipoServicio servicio))
            return OpcionNoPermitida("Servicio", CatalogoOpciones.Servicios);

        if (!CatalogoOpciones.IntentarConvertir(request.Plan, out TipoPlan plan))
            return OpcionNoPermitida("Plan", CatalogoOpciones.Planes);

        if (!CatalogoOpciones.IntentarConvertir(request.Notificacion, out CanalNotificacion canal))
            return OpcionNoPermitida("Aviso", CatalogoOpciones.Notificaciones);

        try
        {
            var plantilla = PrepararPlantilla(servicio, request.Tareas);

            var orden = new OrdenReparacionBuilder()
                .ParaCliente(request.Cliente)
                .ConEquipo(equipo)
                .ConFalla(request.Falla)
                .DesdePlantilla(plantilla)
                .ConPlan(_fabricasPlan.Single(f => f.Plan == plan))
                .ConNotificacion(canal)
                .ConRepuesto(request.Repuesto)
                .Construir();

            _repositorio.Agregar(orden);
            RegistrarEnBitacora(orden);

            var aviso = _creadoresNotificador.Single(c => c.Canal == orden.Notificacion).Notificar(orden);

            return ResultadoOperacion.Correcto(
                $"Orden {orden.Id} registrada para {orden.Cliente}.{Environment.NewLine}" +
                $"Total: ${FormatearMonto(orden.Total)}{Environment.NewLine}" +
                $"Garantía: {orden.GarantiaDias} días{Environment.NewLine}" +
                $"Estado: {CatalogoOpciones.Texto(orden.Estado)}{Environment.NewLine}" +
                aviso);
        }
        catch (ReglaNegocioException ex)
        {
            return ResultadoOperacion.Fallo(ex.Message);
        }
    }

    private PlantillaOrden PrepararPlantilla(TipoServicio servicio, IReadOnlyList<string> tareas)
    {
        var copia = _plantillas.ObtenerCopia(servicio);
        var tareasEditadas = tareas
            .Select(t => t.Trim())
            .Where(t => t.Length > 0)
            .ToList();

        if (tareasEditadas.Count > 0)
            copia.PersonalizarTareas(tareasEditadas);

        return copia;
    }

    private void RegistrarEnBitacora(OrdenReparacion orden)
    {
        _bitacora.Registrar(
            $"Orden {orden.Id} guardada. Total ${FormatearMonto(orden.Total)}. Garantía {orden.GarantiaDias} días.");
        _bitacora.Registrar(
            $"Orden {orden.Id} usa una copia de la plantilla {CatalogoOpciones.Texto(orden.Servicio)} " +
            $"con {orden.Tareas.Count} tareas; la original conserva {_plantillas.TareasOriginales(orden.Servicio).Count}.");
    }

    private static ResultadoOperacion OpcionNoPermitida(string campo, IReadOnlyList<string> opciones) =>
        ResultadoOperacion.Fallo($"{campo} no permitido. Opciones válidas: {string.Join(", ", opciones)}.");

    private static string FormatearMonto(decimal monto) => monto.ToString("0.00", CultureInfo.InvariantCulture);
}
