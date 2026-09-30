using ReparaLab.Domain.Entities;
using ReparaLab.Domain.Interfaces;

namespace ReparaLab.Infrastructure.Repositories;

public class OrdenRepositoryMemoria : IOrdenRepository
{
    private readonly List<OrdenReparacion> _ordenes = new();
    private int _siguienteId = 1;

    public void Agregar(OrdenReparacion orden)
    {
        orden.AsignarId(_siguienteId++);
        _ordenes.Add(orden);
    }

    public OrdenReparacion? ObtenerPorId(int id) => _ordenes.FirstOrDefault(o => o.Id == id);

    public IReadOnlyList<OrdenReparacion> ObtenerTodas() => _ordenes.AsReadOnly();
}
