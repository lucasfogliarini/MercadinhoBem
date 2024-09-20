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
        public void Next()
        {
            Order order = new(_notification, [])
            {
                State = new AwaitingProcessingState(_notification)
            };

            order.Next();

            Assert.True(order.State is ProcessingPaymentState);
            _notification.DidNotReceive().Notify(Arg.Any<string>());
        }
    }
}