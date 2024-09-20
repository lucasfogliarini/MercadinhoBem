using MercadinhoBem.Domain.Notification;
using MercadinhoBem.Domain.Orders;
using MercadinhoBem.Domain.Orders.States;
using NSubstitute;

namespace MercadinhoBem.Tests
{
    public class CancelededStateTests
    {
        readonly INotification _notification = Substitute.For<INotification>();

        [Fact]
        public void Next()
        {
            Order order = new(_notification, [])
            {
                State = new CancelededState(_notification)
            };

            order.Next();

            Assert.True(order.State is CancelededState);
            _notification.Received(1).Notify(Arg.Any<string>());
        }
    }
}