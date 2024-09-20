using MercadinhoBem.Domain.Notification;
using MercadinhoBem.Domain.Orders;
using MercadinhoBem.Domain.Orders.States;
using NSubstitute;

namespace MercadinhoBem.Tests
{
    public class AwaitingProcessingStateTests
    {
        readonly INotification _notification = Substitute.For<INotification>();

        [Fact]
        public void Next_With_Items_And_CustomerEmail()
        {
            Order order = new(_notification, [])
            {
                State = new AwaitingProcessingState(_notification),
                CustomerEmail = "CustomerEmail",
                Items =
                [
                    new OrderItem(null, 1)
                ]
            };

            order.Next();

            Assert.True(order.State is ProcessingPaymentState);
            _notification.DidNotReceive().Notify(Arg.Any<string>());
        }

        [Fact]
        public void Next_Without_Items()
        {
            Order order = new(_notification, [])
            {
                State = new AwaitingProcessingState(_notification),
                CustomerEmail = "CustomerEmail"
            };

            Assert.Throws<Exception>(order.Next);

            Assert.True(order.State is AwaitingProcessingState);
            _notification.DidNotReceive().Notify(Arg.Any<string>());
        }

        [Fact]
        public void Next_Without_CustomerEmail()
        {
            Order order = new(_notification, [])
            {
                State = new AwaitingProcessingState(_notification),
                Items =
                [
                    new OrderItem(null, 1)
                ]
            };

            Assert.Throws<Exception>(order.Next);

            Assert.True(order.State is AwaitingProcessingState);
            _notification.DidNotReceive().Notify(Arg.Any<string>());
        }
    }
}