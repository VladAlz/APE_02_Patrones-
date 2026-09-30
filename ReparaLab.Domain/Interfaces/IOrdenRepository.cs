using ReparaLab.Domain.Entities;

namespace ReparaLab.Domain.Interfaces;

public interface IOrdenRepository
{
    void Agregar(OrdenReparacion orden);
    OrdenReparacion? ObtenerPorId(int id);
    IReadOnlyList<OrdenReparacion> ObtenerTodas();
}
