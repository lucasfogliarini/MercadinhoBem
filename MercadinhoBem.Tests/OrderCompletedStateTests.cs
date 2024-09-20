using MercadinhoBem.Domain.Notification;
using MercadinhoBem.Domain.Orders;
using MercadinhoBem.Domain.Orders.States;
using NSubstitute;

namespace MercadinhoBem.Tests
{
    public class OrderCompletedStateTests
    {
        readonly INotification _notification = Substitute.For<INotification>();

        [Fact]
        public void Next()
        {
            Order order = new(_notification, [])
            {
                State = new OrderCompletedState(_notification)
            };

            order.Next();

            Assert.True(order.State is OrderCompletedState);
            _notification.Received(1).Notify(Arg.Any<string>());
        }

        [Fact]
        public void Cancel()
        {
            Order order = new(_notification, [])
            {
                State = new OrderCompletedState(_notification)
            };

            Assert.Throws<Exception>(order.Cancel);

            Assert.True(order.State is OrderCompletedState);
            _notification.DidNotReceive().Notify(Arg.Any<string>());
        }
    }
}