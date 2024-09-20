using MercadinhoBem.Domain.Notification;
using MercadinhoBem.Domain.Orders;
using MercadinhoBem.Domain.Orders.States;
using MercadinhoBem.Domain.Payment;
using NSubstitute;

namespace MercadinhoBem.Tests
{
    public class ProcessingPaymentStateTests
    {
        readonly INotification _notification = Substitute.For<INotification>();

        [Fact]
        public void Next_Without_PaymentStrategy()
        {
            Order order = new(_notification, [])
            {
                State = new ProcessingPaymentState(_notification)
            };

            Assert.Throws<ArgumentException>(order.Next);

            Assert.True(order.State is ProcessingPaymentState);
            _notification.Received(1).Notify(Arg.Any<string>());
        }

        [Fact]
        public void Next_With_PaymentCompleted()
        {
            Order order = new(_notification, [])
            {
                State = new ProcessingPaymentState(_notification),
                PaymentStrategy = Substitute.For<PaymentStrategy>()
            };

            order.PaymentStrategy.Pay(Arg.Any<Order>()).Returns(true);

            order.Next();

            Assert.True(order.State is PaymentCompletedState);
            _notification.Received(1).Notify(Arg.Any<string>());
        }

        [Fact]
        public void Next_With_PaymentFailed()
        {
            Order order = new(_notification, [])
            {
                State = new ProcessingPaymentState(_notification),
                PaymentStrategy = Substitute.For<PaymentStrategy>()
            };

            order.PaymentStrategy.Pay(Arg.Any<Order>()).Returns(false);

            order.Next();

            Assert.True(order.State is CancelededState);
            _notification.Received(3).Notify(Arg.Any<string>());
        }
    }
}