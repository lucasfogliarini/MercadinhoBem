using System.Net.Mail;
using System.Net;

namespace MercadinhoBem.Domain.Notification
{
    public class EmailNotification : INotification
    {
        readonly SmtpClient _smtpClient;
        const string _systemEmail = "noreply@mercadinhobem.com";

        public EmailNotification()
        {
            _smtpClient = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                //inboxes: https://mailtrap.io/inboxes/3148502/messages/
                Credentials = new NetworkCredential("9d6c2d19c30298", "fe181b2f1c69a3"),
                EnableSsl = true,
            };
        }
        public void Notify(string to, string message)
        {
            _smtpClient.Send(_systemEmail, to, message, message);
            Console.WriteLine($"Email enviado: {message}");
        }
    }
}
