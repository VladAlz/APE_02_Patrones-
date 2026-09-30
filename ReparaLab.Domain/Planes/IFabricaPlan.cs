using ReparaLab.Domain.Enums;

namespace ReparaLab.Domain.Planes;

public interface IFabricaPlan
{
    TipoPlan Plan { get; }
    IPoliticaTarifa CrearPoliticaTarifa();
    IPoliticaGarantia CrearPoliticaGarantia();
}
