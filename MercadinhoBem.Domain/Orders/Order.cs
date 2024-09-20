using MercadinhoBem.Domain.Discounts;
using MercadinhoBem.Domain.Notification;
using MercadinhoBem.Domain.Orders.States;
using MercadinhoBem.Domain.Payment;
using MercadinhoBem.Domain.Products;

namespace MercadinhoBem.Domain.Orders
{
    public class Order(INotification notification, params IDiscountStrategy[] discounts)
    {
        public string Id { get; init; } = Guid.NewGuid().ToString().Substring(0, 6);

        public DateTime Data { get; init; } = DateTime.Now;
        public List<OrderItem> Items { get; init; } = [];
        public decimal TotalAmount { get; set; }

        public string CustomerEmail { get; set; }
        public string StateDescription { get { return State.Description;  } }
        public string? PaymentDescription {  get { return PaymentStrategy?.Description; } }
        public OrderState State { get; set; } = new AwaitingProcessingState(notification);

        private readonly INotification _notification = notification;
        private IDiscountStrategy[] _discounts = discounts;
        public PaymentStrategy PaymentStrategy { get; set; }

        public void AddItem(Product product, int quantity = 1)
        {
            var orderItem = Items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (orderItem == null)
            {
                orderItem = new OrderItem(product, 0);
                Items.Add(orderItem);
            }

            orderItem.Quantity += quantity;
        }
        public decimal CalculateTotalAmount()
        {
            TotalAmount = 0;
            foreach (var item in Items)
            {
                TotalAmount += item.Product.Price * item.Quantity;
            }
            foreach (var discount in _discounts)
            {
                TotalAmount -= discount.ApplyDiscount(this);
            }

            if(PaymentStrategy != null)
            {
                TotalAmount -= PaymentStrategy.ApplyDiscount(TotalAmount);
            }

            return TotalAmount;
        }

        public void Cancel()
        {
            State?.Cancel(this);
        }

        public void Next()
        {
            State?.Next(this);
        }
    }
}
