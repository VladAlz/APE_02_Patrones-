using ReparaLab.Application.Common;
using ReparaLab.Application.DTOs;
using ReparaLab.Domain.Enums;
using ReparaLab.Domain.Prototypes;

namespace ReparaLab.Application.Queries;

public class ObtenerPlantillaUseCase
{
    private readonly CatalogoPlantillas _plantillas;

    public ObtenerPlantillaUseCase(CatalogoPlantillas plantillas)
    {
        _plantillas = plantillas;
    }

    public PlantillaDto? Ejecutar(string servicio)
    {
        if (!CatalogoOpciones.IntentarConvertir(servicio, out TipoServicio tipo))
            return null;

        var copia = _plantillas.ObtenerCopia(tipo);
        return new PlantillaDto(CatalogoOpciones.Texto(copia.Servicio), copia.Tareas.ToList());
    }
}
