using ReparaLab.Domain.Entities;
using ReparaLab.Domain.Enums;

namespace ReparaLab.Domain.Notificaciones;

public abstract class CreadorNotificador
{
    public abstract CanalNotificacion Canal { get; }

    protected abstract INotificador CrearNotificador();

    public string Notificar(OrdenReparacion orden)
    {
        var notificador = CrearNotificador();
        return notificador.Enviar(orden);
    }
}
