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
        public EmailNotification(string to)
        {
            To = to;
            _smtpClient = SmtpClient();
        }
        public string? To { get; set; }

        readonly SmtpClient _smtpClient;
        const string _systemEmail = "noreply@mercadinhobem.com";
        public void Notify(string message, string subject = "Notificação Mercadinho Bem")
        {
            _smtpClient.Send(_systemEmail, To, subject, message);
        }

        private SmtpClient SmtpClient()
        {
            var smtpClient = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                //inboxes: https://mailtrap.io/inboxes/3154321/messages/
                Credentials = new NetworkCredential("b1f2b0eb37a95e", "29676a58f85631"),
                EnableSsl = true,
            };
            return smtpClient;
        }
    }
}
