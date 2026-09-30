using ReparaLab.Domain.Enums;

namespace ReparaLab.Domain.Planes;

public class FabricaPlanBasico : IFabricaPlan
{
    public TipoPlan Plan => TipoPlan.Basico;

    public IPoliticaTarifa CrearPoliticaTarifa() => new TarifaBasica();

    public IPoliticaGarantia CrearPoliticaGarantia() => new GarantiaBasica();
}
