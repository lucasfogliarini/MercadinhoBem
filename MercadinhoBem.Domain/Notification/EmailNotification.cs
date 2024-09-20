using System.Net.Mail;
using System.Net;
using System.Diagnostics.CodeAnalysis;

namespace MercadinhoBem.Domain.Notification
{
    [ExcludeFromCodeCoverage]
    public class EmailNotification : INotification
    {
        public EmailNotification()
        {
            _smtpClient = SmtpClient();
        }
        public string? To { get; set; }

        readonly SmtpClient _smtpClient;
        const string _systemEmail = "noreply@mercadinhobem.com";
        public void Notify(string message)
        {
            _smtpClient.Send(_systemEmail, To, message, message);
        }

        private SmtpClient SmtpClient()
        {
            var smtpClient = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                //inboxes: https://mailtrap.io/inboxes/3148502/messages/
                Credentials = new NetworkCredential("9d6c2d19c30298", "fe181b2f1c69a3"),
                EnableSsl = true,
            };
            return smtpClient;
        }
    }
}
