using MercadinhoBem.Domain.Orders;

namespace MercadinhoBem.Domain.Discounts
{
    public class QuantityDiscountStrategy(int quantity, decimal discountPercentage) : IDiscountStrategy
    {
        private readonly int _quantity = quantity;
        private readonly decimal _discountPercentage = discountPercentage;
        public decimal ApplyDiscount(Order order)
        {
            decimal discount = 0;
            foreach (var item in order.Items)
            {
                if (item.Quantity >= _quantity)
                {
                    discount += item.Total * _discountPercentage / 100;
                }
            }
            return discount;
        }
    }
}
