using MercadinhoBem.Notification;
using System.Net.Mail;
using System.Net;

namespace MercadinhoBem.Tests
{
    public class EmailNotificationTests
    {
        [Fact]
        public void Notify()
        {
            var customerEmail = "customer@mail.com";
            var emailNotification = new EmailNotification(customerEmail);

            //emailNotification.Notify("");
        }
    }
}