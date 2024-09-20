using MercadinhoBem.Domain.Notification;

namespace MercadinhoBem.Domain.Orders.States
{
    public class CancelededState(INotification notification) : OrderState(notification)
    {
        public override string Description => "Pedido Cancelado";
        public override string NextStateDescription => null;
        public override void Next(Order order)
        {
            NotifyStateChanged(order, Description);
        }

        public override void Cancel(Order order)
        {
            throw new Exception("O pedido já está cancelado.");
        }
    }
}
