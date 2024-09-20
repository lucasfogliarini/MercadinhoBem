using MercadinhoBem.Domain.Products;
using NSubstitute;
using MercadinhoBem.Domain.Notification;
using MercadinhoBem.Domain.Orders;
using MercadinhoBem.Domain.Orders.States;

namespace MercadinhoBem.Tests
{
    public class SeparatingOrderStateTests
    {
        readonly List<Product> _products = [
            new(1, "Feijão", 6, 6),
            new(2, "Arroz", 4, 5),
            new(3, "Queijo", 10, 5),
            new(4, "Presunto", 10, 10),
        ];

        readonly INotification _notification = Substitute.For<INotification>();

        [Fact]
        public void Next_With_ProductItemMissing()
        {
            Order order = new(_notification, [])
            {
                State = new SeparatingOrderState(_notification)
            };
            order.AddItem(GetProduct(1), 7);

            order.Next();

            Assert.True(order.State is WaitingForStockState);
            _notification.Received(2).Notify(Arg.Any<string>());
        }

        [Fact]
        public void Next_With_ProductItemOk()
        {
            Order order = new(_notification, [])
            {
                State = new SeparatingOrderState(_notification)
            };
            order.AddItem(GetProduct(1), 6);

            order.Next();

            Assert.True(order.State is OrderCompletedState);
            _notification.Received(1).Notify(Arg.Any<string>());
        }

        [Fact]
        public void Cancel()
        {
            Order order = new(_notification, [])
            {
                State = new SeparatingOrderState(_notification)
            };

            order.Cancel();

            Assert.True(order.State is CancelededState);
            _notification.Received(1).Notify(Arg.Any<string>());
        }

        public Product GetProduct(int id)
        {
            return _products.FirstOrDefault(p=>p.Id == id);
        }
    }
}