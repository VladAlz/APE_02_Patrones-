using ReparaLab.Domain.Entities;

namespace ReparaLab.Domain.Notificaciones;

public interface INotificador
{
    string Enviar(OrdenReparacion orden);
}
