using MercadinhoBem.Domain.Discounts;
using MercadinhoBem.Domain.Notification;
using MercadinhoBem.Domain.Orders;
using MercadinhoBem.Domain.Payment;
using MercadinhoBem.Domain.Products;
using NSubstitute;

namespace MercadinhoBem.Tests
{
    public class OrderTests
    {
        readonly List<Product> _products = [
            new(1, "Feijão", 6, 6),
            new(2, "Arroz", 4, 5),
            new(3, "Queijo", 10, 5),
            new(4, "Presunto", 10, 10),
        ];

        readonly INotification _notification = Substitute.For<INotification>();

        [Fact]
        public void CalculateTotalAmount_Without_Discount()
        {
            Order order = new(_notification, []);
            order.AddItem(GetProduct(1), 2);
            order.AddItem(GetProduct(2), 3);
            order.AddItem(GetProduct(2), 1);

            var totalAmount = order.CalculateTotalAmount();

            Assert.Equal(28, totalAmount);
        }

        [Theory]
        [InlineData(3, 10, 37)]
        [InlineData(4, 15, 44)]
        [InlineData(5, 20, 50)]
        public void CalculateTotalAmount_With_QuantityDiscount(int quantity, decimal discountPercentage, decimal expectedTotalAmount)
        {
            Order order = new(_notification, new QuantityDiscountStrategy(quantity, discountPercentage));
            order.AddItem(GetProduct(3), quantity);
            order.AddItem(GetProduct(4), 1);

            var totalAmount = order.CalculateTotalAmount();

            Assert.Equal(expectedTotalAmount, totalAmount);
        }

        [Fact]
        public void CalculateTotalAmount_With_SeasonalDiscount_InCurrentMonth()
        {
            int month = DateTime.Now.Month;
            Order order = new(_notification, new SeasonalDiscountStrategy(month, 10));
            order.AddItem(GetProduct(3), 1);

            var totalAmount = order.CalculateTotalAmount();

            Assert.Equal(9, totalAmount);
        }

        [Fact]
        public void CalculateTotalAmount_With_SeasonalDiscount_InAnotherMonth()
        {
            int month = DateTime.Now.Month + 1;
            Order order = new(_notification, new SeasonalDiscountStrategy(month, 10));
            order.AddItem(GetProduct(3), 1);

            var totalAmount = order.CalculateTotalAmount();

            Assert.Equal(10, totalAmount);
        }

        [Fact]
        public void CalculateTotalAmount_With_PixStrategyDiscount()
        {
            Order order = new(_notification);
            order.AddItem(GetProduct(3), 1);
            order.PaymentStrategy = new PixPaymentStrategy(5);

            var totalAmount = order.CalculateTotalAmount();

            Assert.Equal(9.5m, totalAmount);
        }

        public Product GetProduct(int id)
        {
            return _products.FirstOrDefault(p=>p.Id == id);
        }
    }
}