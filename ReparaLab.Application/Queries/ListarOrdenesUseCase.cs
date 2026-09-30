using ReparaLab.Application.DTOs;
using ReparaLab.Domain.Interfaces;

namespace ReparaLab.Application.Queries;

public class ListarOrdenesUseCase
{
    private readonly IOrdenRepository _repositorio;

    public ListarOrdenesUseCase(IOrdenRepository repositorio)
    {
        _repositorio = repositorio;
    }

    public IReadOnlyList<OrdenDto> Ejecutar() =>
        _repositorio.ObtenerTodas()
            .OrderBy(o => o.Id)
            .Select(OrdenDto.Desde)
            .ToList();
}
