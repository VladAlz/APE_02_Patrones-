using ReparaLab.Domain.Enums;
using ReparaLab.Domain.Interfaces;
using ReparaLab.Domain.Notificaciones;

namespace ReparaLab.Infrastructure.Notificaciones;

public class CreadorNotificadorEmail : CreadorNotificador
{
    private readonly IBitacora _bitacora;

    public CreadorNotificadorEmail(IBitacora bitacora)
    {
        _bitacora = bitacora;
    }

    public override CanalNotificacion Canal => CanalNotificacion.Email;

    protected override INotificador CrearNotificador() => new NotificadorEmail(_bitacora);
}
