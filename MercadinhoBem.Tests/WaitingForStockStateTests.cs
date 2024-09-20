using MercadinhoBem.Domain.Notification;
using MercadinhoBem.Domain.Orders;
using MercadinhoBem.Domain.Orders.States;
using NSubstitute;

namespace MercadinhoBem.Tests
{
    public class WaitingForStockStateTests
    {
        readonly INotification _notification = Substitute.For<INotification>();

        [Fact]
        public void Next()
        {
            Order order = new(_notification, [])
            {
                State = new WaitingForStockState(_notification)
            };

            order.Next();

            Assert.True(order.State is WaitingForStockState);
            _notification.Received(1).Notify(Arg.Any<string>());
        }

        [Fact]
        public void Cancel()
        {
            Order order = new(_notification, [])
            {
                State = new WaitingForStockState(_notification)
            };

            order.Cancel();

            Assert.True(order.State is CancelededState);
            _notification.Received(2).Notify(Arg.Any<string>());
        }
    }
}