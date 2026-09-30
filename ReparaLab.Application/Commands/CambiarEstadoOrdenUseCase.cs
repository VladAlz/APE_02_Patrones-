using ReparaLab.Application.Common;
using ReparaLab.Application.DTOs;
using ReparaLab.Domain.Enums;
using ReparaLab.Domain.Exceptions;
using ReparaLab.Domain.Interfaces;

namespace ReparaLab.Application.Commands;

public class CambiarEstadoOrdenUseCase
{
    private readonly IOrdenRepository _repositorio;
    private readonly IBitacora _bitacora;

    public CambiarEstadoOrdenUseCase(IOrdenRepository repositorio, IBitacora bitacora)
    {
        _repositorio = repositorio;
        _bitacora = bitacora;
    }

    public ResultadoOperacion Ejecutar(int idOrden, EstadoOrden nuevoEstado)
    {
        var orden = _repositorio.ObtenerPorId(idOrden);
        if (orden is null)
            return ResultadoOperacion.Fallo("Orden no encontrada.");

        try
        {
            orden.CambiarEstado(nuevoEstado);
        }
        catch (ReglaNegocioException ex)
        {
            _bitacora.Registrar($"Cambio rechazado en la orden {idOrden}: {ex.Message}");
            return ResultadoOperacion.Fallo(ex.Message);
        }

        var estado = CatalogoOpciones.Texto(orden.Estado);
        _bitacora.Registrar($"Orden {idOrden} -> {estado}");
        return ResultadoOperacion.Correcto($"La orden {idOrden} cambió a {estado}.");
    }
}
