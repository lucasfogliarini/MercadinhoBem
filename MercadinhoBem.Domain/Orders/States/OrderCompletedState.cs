using MercadinhoBem.Domain.Notification;

namespace MercadinhoBem.Domain.Orders.States
{
    public class OrderCompletedState(INotification notification) : OrderState(notification)
    {
        public override string Description => "Pedido Concluído";
        public override string NextStateDescription => null;
        public override void Next(Order order)
        {
            NotifyStateChanged(order, Description);
        }

        public override void Cancel(Order order)
        {
            throw new Exception("Não é possível cancelar um pedido já concluído.");
        }
    }
}
