namespace MercadinhoBem.Domain.Notification
{
    public interface INotification
    {
        void Notify(string to, string message);
    }
}
