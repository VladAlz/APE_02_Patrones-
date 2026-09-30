using ReparaLab.Domain.Enums;
using ReparaLab.Domain.Exceptions;

namespace ReparaLab.Domain.Prototypes;

public class CatalogoPlantillas
{
    private readonly Dictionary<TipoServicio, PlantillaOrden> _originales = new()
    {
        [TipoServicio.Diagnostico] = new PlantillaOrden(TipoServicio.Diagnostico, new[]
        {
            "Revisión física del equipo",
            "Prueba de encendido y carga",
            "Registro de hallazgos"
        }),
        [TipoServicio.Mantenimiento] = new PlantillaOrden(TipoServicio.Mantenimiento, new[]
        {
            "Limpieza interna y externa",
            "Revisión de conectores",
            "Actualización de software",
            "Prueba de funcionamiento"
        })
    };

    public PlantillaOrden ObtenerCopia(TipoServicio servicio) => ObtenerOriginal(servicio).Clonar();

    public IReadOnlyList<string> TareasOriginales(TipoServicio servicio) => ObtenerOriginal(servicio).Tareas;

    private PlantillaOrden ObtenerOriginal(TipoServicio servicio) =>
        _originales.TryGetValue(servicio, out var plantilla)
            ? plantilla
            : throw new ReglaNegocioException("No existe una plantilla para el servicio seleccionado.");
}
