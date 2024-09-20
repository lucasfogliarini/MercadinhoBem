using MercadinhoBem.Domain.Notification;

namespace MercadinhoBem.Domain.Orders.States
{
    public class AwaitingProcessingState(INotification notification) : OrderState(notification)
    {
        public override string Description => "Aguardando Processamento";
        public override string NextStateDescription => "Processar Pagamento";
        public override void Next(Order order)
        {
            if (!order.Items.Any())
            {
                throw new Exception("O pedido precisa pelo menos 1 item para processar pagamento.");
            }

            if (string.IsNullOrWhiteSpace(order.CustomerEmail))
            {
                throw new Exception("O pedido precisa de um cliente para processar o pagamento.");
            }
            order.State = new ProcessingPaymentState(Notification);
        }
    }
}
