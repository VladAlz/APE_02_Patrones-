namespace ReparaLab.Domain.Interfaces;

public interface IBitacora
{
    IReadOnlyList<string> Eventos { get; }
    void Registrar(string evento);
}
