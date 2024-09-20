using MercadinhoBem.Domain.Notification;
using MercadinhoBem.Domain.Products;

namespace MercadinhoBem.Domain.Orders.States
{
    public class SeparatingOrderState(INotification notification) : OrderState(notification)
    {
        public override string Description => "Separando Pedido";
        public override string NextStateDescription => "Concluir Pedido";

        readonly IEnumerable<Product> _products = ProductRepository.GetProducts();
        public override void Next(Order order)
        {
            NotifyStateChanged(order, Description);
            bool isProductItemMissing = false;
            foreach (var orderItem in order.Items)
            {
                var product = _products.FirstOrDefault(p => p.Id == orderItem.Product.Id);
                if(product.Quantity < orderItem.Quantity)
                {
                    isProductItemMissing = true;
                    var missingQuantity = orderItem.Quantity - product.Quantity;
                    Notification.Notify(order.CustomerEmail, $"O produto {product.Name} está em falta de {missingQuantity} itens para o pedido {order.Id}");
                }
            }
            if (isProductItemMissing)
                order.State = new WaitingForStockState(Notification);
            else
                order.State = new OrderCompletedState(Notification);
        }

        public override void Cancel(Order order)
        {
            Refund(order);
            base.Cancel(order);
        }
    }
}
