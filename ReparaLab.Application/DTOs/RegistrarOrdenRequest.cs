namespace ReparaLab.Application.DTOs;

public class RegistrarOrdenRequest
{
    public string Cliente { get; init; } = string.Empty;
    public string Equipo { get; init; } = string.Empty;
    public string Falla { get; init; } = string.Empty;
    public string Servicio { get; init; } = string.Empty;
    public string Plan { get; init; } = string.Empty;
    public string Notificacion { get; init; } = string.Empty;
    public bool Repuesto { get; init; }
    public IReadOnlyList<string> Tareas { get; init; } = Array.Empty<string>();
}
