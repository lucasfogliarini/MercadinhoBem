using MercadinhoBem.Domain.Notification;

namespace MercadinhoBem.Domain.Orders.States
{
    public abstract class OrderState(INotification notification)
    {
        public INotification Notification { get; } = notification;

        public abstract string Description { get; }
        public abstract string NextStateDescription { get; }
        public abstract void Next(Order order);
        public virtual void Cancel(Order order)
        {
            if (Notification.To == null)
                throw new Exception("Precisa de um destinatário para enviar a notificação de cancelamento.");

            order.State = new CancelededState(Notification);
            order.State.Next(order);
        }

        public void Refund(Order order)
        {
            Thread.Sleep(1000);
            Notification.Notify($"O pedido '{order.Id}' foi estornado com sucesso.");
        }
        public void NotifyStateChanged(Order order, string state)
        {
            Notification.Notify($"O pedido '{order.Id}' alterou para '{state}'");
        }
    }
}
