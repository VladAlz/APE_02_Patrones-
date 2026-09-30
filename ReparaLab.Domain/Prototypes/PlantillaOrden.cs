using ReparaLab.Domain.Enums;
using ReparaLab.Domain.Exceptions;

namespace ReparaLab.Domain.Prototypes;

public class PlantillaOrden
{
    private List<string> _tareas;

    public TipoServicio Servicio { get; }
    public IReadOnlyList<string> Tareas => _tareas.AsReadOnly();

    public PlantillaOrden(TipoServicio servicio, IEnumerable<string> tareas)
    {
        Servicio = servicio;
        _tareas = tareas.ToList();
    }

    public PlantillaOrden Clonar()
    {
        var copia = (PlantillaOrden)MemberwiseClone();
        copia._tareas = new List<string>(_tareas);
        return copia;
    }

    public void PersonalizarTareas(IReadOnlyList<string> tareas)
    {
        if (tareas.Count == 0)
            throw new ReglaNegocioException("La plantilla debe conservar al menos una tarea.");

        _tareas.Clear();
        _tareas.AddRange(tareas);
    }
}
