using Microsoft.Extensions.DependencyInjection;
using ReparaLab.Application.Commands;
using ReparaLab.Application.Queries;
using ReparaLab.Domain.Interfaces;
using ReparaLab.Domain.Notificaciones;
using ReparaLab.Domain.Planes;
using ReparaLab.Domain.Prototypes;
using ReparaLab.Infrastructure.Logging;
using ReparaLab.Infrastructure.Notificaciones;
using ReparaLab.Infrastructure.Repositories;

namespace ReparaLab.WinForms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        using var proveedor = ConfigurarServicios();
        System.Windows.Forms.Application.Run(proveedor.GetRequiredService<FrmReparaciones>());
    }

    private static ServiceProvider ConfigurarServicios()
    {
        var servicios = new ServiceCollection();

        servicios.AddSingleton<IBitacora>(Bitacora.Instancia);
        servicios.AddSingleton<IOrdenRepository, OrdenRepositoryMemoria>();
        servicios.AddSingleton<CatalogoPlantillas>();

        servicios.AddSingleton<IFabricaPlan, FabricaPlanBasico>();
        servicios.AddSingleton<IFabricaPlan, FabricaPlanPremium>();

        servicios.AddSingleton<CreadorNotificador, CreadorNotificadorEmail>();
        servicios.AddSingleton<CreadorNotificador, CreadorNotificadorSms>();

        servicios.AddTransient<RegistrarOrdenUseCase>();
        servicios.AddTransient<CambiarEstadoOrdenUseCase>();
        servicios.AddTransient<ListarOrdenesUseCase>();
        servicios.AddTransient<ObtenerPlantillaUseCase>();
        servicios.AddTransient<ConsultarBitacoraUseCase>();

        servicios.AddTransient<FrmReparaciones>();

        return servicios.BuildServiceProvider();
    }
}
