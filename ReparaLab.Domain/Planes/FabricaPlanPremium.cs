using ReparaLab.Domain.Enums;

namespace ReparaLab.Domain.Planes;

public class FabricaPlanPremium : IFabricaPlan
{
    public TipoPlan Plan => TipoPlan.Premium;

    public IPoliticaTarifa CrearPoliticaTarifa() => new TarifaPremium();

    public IPoliticaGarantia CrearPoliticaGarantia() => new GarantiaPremium();
}
