using ReparaLab.Domain.Enums;
using ReparaLab.Domain.Exceptions;

namespace ReparaLab.Domain.Entities;

public class OrdenReparacion
{
    public int Id { get; private set; }
    public string Cliente { get; }
    public TipoEquipo Equipo { get; }
    public string Falla { get; }
    public TipoServicio Servicio { get; }
    public TipoPlan Plan { get; }
    public CanalNotificacion Notificacion { get; }
    public bool Repuesto { get; }
    public IReadOnlyList<string> Tareas { get; }
    public decimal Total { get; }
    public int GarantiaDias { get; }
    public EstadoOrden Estado { get; private set; }

    internal OrdenReparacion(
        string cliente,
        TipoEquipo equipo,
        string falla,
        TipoServicio servicio,
        TipoPlan plan,
        CanalNotificacion notificacion,
        bool repuesto,
        IEnumerable<string> tareas,
        decimal total,
        int garantiaDias)
    {
        Cliente = cliente;
        Equipo = equipo;
        Falla = falla;
        Servicio = servicio;
        Plan = plan;
        Notificacion = notificacion;
        Repuesto = repuesto;
        Tareas = tareas.ToList().AsReadOnly();
        Total = total;
        GarantiaDias = garantiaDias;
        Estado = EstadoOrden.Pendiente;
    }

    public void AsignarId(int id)
    {
        if (Id != 0)
            throw new ReglaNegocioException("La orden ya tiene un identificador asignado.");

        Id = id;
    }

    public void CambiarEstado(EstadoOrden nuevoEstado)
    {
        if (Estado != EstadoOrden.Pendiente)
            throw new ReglaNegocioException(
                $"Solo se puede modificar una orden PENDIENTE. La orden {Id} está {Estado.ToString().ToUpperInvariant()}.");

        if (nuevoEstado == EstadoOrden.Pendiente)
            throw new ReglaNegocioException("Una orden pendiente solo puede pasar a FINALIZADA o CANCELADA.");

        Estado = nuevoEstado;
    }
}
