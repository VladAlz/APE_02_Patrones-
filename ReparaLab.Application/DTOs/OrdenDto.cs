using ReparaLab.Application.Common;
using ReparaLab.Domain.Entities;

namespace ReparaLab.Application.DTOs;

public record OrdenDto(
    int Id,
    string Cliente,
    string Equipo,
    string Servicio,
    string Plan,
    string Tareas,
    decimal Total,
    int GarantiaDias,
    string Estado)
{
    public static OrdenDto Desde(OrdenReparacion orden) => new(
        orden.Id,
        orden.Cliente,
        CatalogoOpciones.Texto(orden.Equipo),
        CatalogoOpciones.Texto(orden.Servicio),
        CatalogoOpciones.Texto(orden.Plan),
        string.Join(", ", orden.Tareas),
        orden.Total,
        orden.GarantiaDias,
        CatalogoOpciones.Texto(orden.Estado));
}
