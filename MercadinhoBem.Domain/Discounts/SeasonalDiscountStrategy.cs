using MercadinhoBem.Domain.Orders;

namespace MercadinhoBem.Domain.Discounts
{
    public class SeasonalDiscountStrategy(int month, decimal discountPercentage) : IDiscountStrategy
    {
        private readonly int _month = month;
        private readonly decimal _discountPercentage = discountPercentage;
        public decimal ApplyDiscount(Order order)
        {
            if (DateTime.Now.Month == _month)
            {
                return order.TotalAmount * _discountPercentage / 100;
            }
            return 0;
        }
    }
}
