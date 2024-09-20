namespace MercadinhoBem.Domain.Notification
{
    public interface INotification
    {
        public string? To { get; set; }
        void Notify(string message, string subject = "Notificação Mercadinho Bem");
    }
}
