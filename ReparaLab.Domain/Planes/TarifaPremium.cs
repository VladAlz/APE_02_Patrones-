namespace ReparaLab.Domain.Planes;

public class TarifaPremium : IPoliticaTarifa
{
    private const decimal Recargo = 0.25m;

    public decimal AplicarPlan(decimal precioServicio) => precioServicio * (1 + Recargo);
}
