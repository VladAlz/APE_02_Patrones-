using ReparaLab.Domain.Interfaces;

namespace ReparaLab.Infrastructure.Logging;

public sealed class Bitacora : IBitacora
{
    private static readonly Lazy<Bitacora> _instancia = new(() => new Bitacora());
    private readonly List<string> _eventos = new();

    private Bitacora()
    {
    }

    public static Bitacora Instancia => _instancia.Value;

    public IReadOnlyList<string> Eventos => _eventos.AsReadOnly();

    public void Registrar(string evento) => _eventos.Add($"{DateTime.Now:HH:mm:ss} | {evento}");
}
