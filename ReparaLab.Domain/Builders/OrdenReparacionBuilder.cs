using ReparaLab.Domain.Entities;
using ReparaLab.Domain.Enums;
using ReparaLab.Domain.Exceptions;
using ReparaLab.Domain.Planes;
using ReparaLab.Domain.Prototypes;

namespace ReparaLab.Domain.Builders;

public class OrdenReparacionBuilder
{
    private string _cliente = string.Empty;
    private string _falla = string.Empty;
    private TipoEquipo _equipo;
    private CanalNotificacion _notificacion;
    private bool _repuesto;
    private PlantillaOrden? _plantilla;
    private IFabricaPlan? _fabricaPlan;

    public OrdenReparacionBuilder ParaCliente(string cliente)
    {
        _cliente = cliente.Trim();
        return this;
    }

    public OrdenReparacionBuilder ConEquipo(TipoEquipo equipo)
    {
        _equipo = equipo;
        return this;
    }

    public OrdenReparacionBuilder ConFalla(string falla)
    {
        _falla = falla.Trim();
        return this;
    }

    public OrdenReparacionBuilder DesdePlantilla(PlantillaOrden plantilla)
    {
        _plantilla = plantilla;
        return this;
    }

    public OrdenReparacionBuilder ConPlan(IFabricaPlan fabricaPlan)
    {
        _fabricaPlan = fabricaPlan;
        return this;
    }

    public OrdenReparacionBuilder ConNotificacion(CanalNotificacion notificacion)
    {
        _notificacion = notificacion;
        return this;
    }

    public OrdenReparacionBuilder ConRepuesto(bool repuesto)
    {
        _repuesto = repuesto;
        return this;
    }

    public OrdenReparacion Construir()
    {
        if (string.IsNullOrWhiteSpace(_cliente))
            throw new ReglaNegocioException("El cliente es obligatorio.");

        if (string.IsNullOrWhiteSpace(_falla))
            throw new ReglaNegocioException("Describa la falla reportada.");

        if (_plantilla is null)
            throw new ReglaNegocioException("La orden requiere una plantilla de servicio.");

        if (_fabricaPlan is null)
            throw new ReglaNegocioException("La orden requiere un plan.");

        var total = CalcularTotal(_plantilla.Servicio, _fabricaPlan.CrearPoliticaTarifa());
        var garantia = _fabricaPlan.CrearPoliticaGarantia();

        return new OrdenReparacion(
            _cliente,
            _equipo,
            _falla,
            _plantilla.Servicio,
            _fabricaPlan.Plan,
            _notificacion,
            _repuesto,
            _plantilla.Tareas,
            total,
            garantia.Dias);
    }

    private decimal CalcularTotal(TipoServicio servicio, IPoliticaTarifa tarifa)
    {
        var total = tarifa.AplicarPlan(Tarifario.PrecioServicio(servicio));
        return _repuesto ? total + Tarifario.PrecioRepuesto : total;
    }
}
