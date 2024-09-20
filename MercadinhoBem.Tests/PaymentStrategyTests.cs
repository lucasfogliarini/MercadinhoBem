using MercadinhoBem.Domain.Notification;
using MercadinhoBem.Domain.Payment;
using NSubstitute;

namespace MercadinhoBem.Tests
{
    public class PaymentStrategyTests
    {
        readonly INotification _notification = Substitute.For<INotification>();

        [Theory]
        [InlineData(5, 100, 5)]
        [InlineData(10, 80, 8)]
        [InlineData(25, 540, 135)]
        public void ApplyDiscount_ForPix(int discountPercentage, decimal amount, decimal expectedDiscount)
        {
            var paymentStrategy = new PixPaymentStrategy(discountPercentage);

            var discount = paymentStrategy.ApplyDiscount(amount);

            Assert.Equal(expectedDiscount, discount);
        }

        [Fact]
        public void ApplyDiscount_ForCreditCard()
        {
            decimal amount = 100;
            var paymentStrategy = new CreditCardPaymentStrategy();

            var discount = paymentStrategy.ApplyDiscount(amount);

            Assert.Equal(0, discount);
        }
    }
}