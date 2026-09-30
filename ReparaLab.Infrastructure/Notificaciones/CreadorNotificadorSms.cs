using ReparaLab.Domain.Enums;
using ReparaLab.Domain.Interfaces;
using ReparaLab.Domain.Notificaciones;

namespace ReparaLab.Infrastructure.Notificaciones;

public class CreadorNotificadorSms : CreadorNotificador
{
    private readonly IBitacora _bitacora;

    public CreadorNotificadorSms(IBitacora bitacora)
    {
        _bitacora = bitacora;
    }

    public override CanalNotificacion Canal => CanalNotificacion.Sms;

    protected override INotificador CrearNotificador() => new NotificadorSms(_bitacora);
}
