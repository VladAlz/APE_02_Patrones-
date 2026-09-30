using ReparaLab.Domain.Enums;

namespace ReparaLab.Application.Common;

public static class CatalogoOpciones
{
    public static IReadOnlyList<string> Equipos { get; } = Nombres<TipoEquipo>();
    public static IReadOnlyList<string> Servicios { get; } = Nombres<TipoServicio>();
    public static IReadOnlyList<string> Planes { get; } = Nombres<TipoPlan>();
    public static IReadOnlyList<string> Notificaciones { get; } = Nombres<CanalNotificacion>();

    public static string Texto<T>(T valor) where T : struct, Enum => valor.ToString().ToUpperInvariant();

    public static bool IntentarConvertir<T>(string? texto, out T valor) where T : struct, Enum
    {
        var nombre = Enum.GetNames<T>()
            .FirstOrDefault(n => string.Equals(n, texto?.Trim(), StringComparison.OrdinalIgnoreCase));

        valor = nombre is null ? default : Enum.Parse<T>(nombre);
        return nombre is not null;
    }

    private static IReadOnlyList<string> Nombres<T>() where T : struct, Enum =>
        Enum.GetValues<T>().Select(Texto).ToList();
}
