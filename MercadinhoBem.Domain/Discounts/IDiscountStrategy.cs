using MercadinhoBem.Domain.Orders;

namespace MercadinhoBem.Domain.Discounts
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(Order order);
    }
}
