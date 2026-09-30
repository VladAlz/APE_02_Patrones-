namespace ReparaLab.Domain.Planes;

public class TarifaBasica : IPoliticaTarifa
{
    public decimal AplicarPlan(decimal precioServicio) => precioServicio;
}
