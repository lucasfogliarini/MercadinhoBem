using MercadinhoBem.Domain.Discounts;
using MercadinhoBem.Domain.Notification;
using MercadinhoBem.Domain.Orders;

namespace MercadinhoBem
{
    public class MercadinhoBemApp
    {
        public List<Order> Orders { get; init; } = [];
        public EmailNotification EmailNotification { get; init; } = new();
        public IDiscountStrategy[] Discounts { get; init; } = 
        {
            new QuantityDiscountStrategy(3, 10),
            new SeasonalDiscountStrategy(6, 15)
        };
    }
}
