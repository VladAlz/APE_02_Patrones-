using ReparaLab.Domain.Entities;
using ReparaLab.Domain.Interfaces;
using ReparaLab.Domain.Notificaciones;

namespace ReparaLab.Infrastructure.Notificaciones;

public class NotificadorEmail : INotificador
{
    private readonly IBitacora _bitacora;

    public NotificadorEmail(IBitacora bitacora)
    {
        _bitacora = bitacora;
    }

    public string Enviar(OrdenReparacion orden)
    {
        var mensaje = $"EMAIL simulado: orden {orden.Id} registrada para {orden.Cliente}.";
        _bitacora.Registrar(mensaje);
        return mensaje;
    }
}
