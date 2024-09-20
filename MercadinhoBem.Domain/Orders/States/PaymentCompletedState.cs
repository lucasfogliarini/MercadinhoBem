using MercadinhoBem.Domain.Notification;

namespace MercadinhoBem.Domain.Orders.States
{
    /// <summary>
    /// Pedidos que estão em "Pagamento Concluído", devem entrar em novo estado que é "Separando Pedido".
    /// </summary>
    public class PaymentCompletedState(INotification notification) : OrderState(notification)
    {
        public override string Description => "Pagamento Concluído";
        public override string NextStateDescription => "Separar Estoque";
        public override void Next(Order order)
        {
            NotifyStateChanged(order, Description);
            order.State = new SeparatingOrderState(Notification);
        }
    }
}
