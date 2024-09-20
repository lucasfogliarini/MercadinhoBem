using MercadinhoBem.Domain.Notification;

namespace MercadinhoBem.Tests
{
    public class EmailNotificationTests
    {
        [Fact]
        public void Notify_Without_To()
        {
            var emailNotification = new EmailNotification();

            Assert.Throws<ArgumentNullException>(() =>
            {
                emailNotification.Notify("message");
            });
        }
    }
}