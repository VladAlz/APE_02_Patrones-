using ReparaLab.Domain.Enums;
using ReparaLab.Domain.Exceptions;

namespace ReparaLab.Domain.Planes;

public static class Tarifario
{
    public const decimal PrecioRepuesto = 15m;

    public static decimal PrecioServicio(TipoServicio servicio) => servicio switch
    {
        TipoServicio.Diagnostico => 20m,
        TipoServicio.Mantenimiento => 35m,
        _ => throw new ReglaNegocioException("El servicio seleccionado no tiene tarifa.")
    };
}
