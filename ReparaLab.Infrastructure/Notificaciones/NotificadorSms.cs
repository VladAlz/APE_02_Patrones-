using ReparaLab.Domain.Entities;
using ReparaLab.Domain.Interfaces;
using ReparaLab.Domain.Notificaciones;

namespace ReparaLab.Infrastructure.Notificaciones;

public class NotificadorSms : INotificador
{
    private readonly IBitacora _bitacora;

    public NotificadorSms(IBitacora bitacora)
    {
        _bitacora = bitacora;
    }

    public string Enviar(OrdenReparacion orden)
    {
        var mensaje = $"SMS simulado a {orden.Cliente}: su orden {orden.Id} fue registrada.";
        _bitacora.Registrar(mensaje);
        return mensaje;
    }
}
