using ReparaLab.Domain.Interfaces;

namespace ReparaLab.Application.Queries;

public class ConsultarBitacoraUseCase
{
    private readonly IBitacora _bitacora;

    public ConsultarBitacoraUseCase(IBitacora bitacora)
    {
        _bitacora = bitacora;
    }

    public IReadOnlyList<string> Ejecutar() => _bitacora.Eventos.ToList();

    public bool ComparteInstanciaCon(IBitacora otraBitacora) => ReferenceEquals(_bitacora, otraBitacora);
}
