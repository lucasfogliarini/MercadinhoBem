using MercadinhoBem.Domain.Notification;

namespace MercadinhoBem.Domain.Orders.States
{
    public class ProcessingPaymentState(INotification notification) : OrderState(notification)
    {
        public override string Description => "Processando Pagamento";
        public override string NextStateDescription => "Pagar";
        public override void Next(Order order)
        {
            NotifyStateChanged(order, Description);

            if(order.PaymentStrategy == null)
            {
                throw new ArgumentException("É preciso configurar o meio de pagamento para pagar.");
            }

            var paymentCompleted = order.PaymentStrategy.Pay(order);
            if (paymentCompleted)
            {
                order.State = new PaymentCompletedState(Notification);
            }
            else
            {
                Notification.Notify(order.CustomerEmail, $"O pedido '{order.Id}' será cancelado, pois houve uma falha ao realizar o pagamento.");
                Cancel(order);
            }
        }
    }
}
