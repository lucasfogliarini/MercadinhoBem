using MercadinhoBem.Domain.Notification;

namespace MercadinhoBem.Domain.Orders.States
{
    public class WaitingForStockState(INotification notification) : OrderState(notification)
    {
        public override string Description => "Aguardando estoque";
        public override string NextStateDescription => null;
        public override void Next(Order order)
        {
            NotifyStateChanged(order, Description);
        }

        public override void Cancel(Order order)
        {
            Refund(order);
            base.Cancel(order);
        }
    }
}
