namespace ReparaLab.Application.DTOs;

public record ResultadoOperacion(bool Exito, string Mensaje)
{
    public static ResultadoOperacion Correcto(string mensaje) => new(true, mensaje);

    public static ResultadoOperacion Fallo(string mensaje) => new(false, mensaje);
}
