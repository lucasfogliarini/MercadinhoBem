using MercadinhoBem.Domain.Notification;
using MercadinhoBem.Domain.Orders;
using System.Text;

namespace MercadinhoBem
{
    internal static class Program
    {
        static MercadinhoBemApp _mercadinhoBemApp;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            _mercadinhoBemApp = new MercadinhoBemApp();
            StartScheduleDailyReport();
            var formOrders = new FormOrders(_mercadinhoBemApp);
            Application.Run(formOrders);
        }

        private static void ScheduleDailyReport(object? sender, EventArgs e)
        {
            var lastDayOrders = _mercadinhoBemApp.Orders.Where(p => p.Data.Date == DateTime.Today.AddDays(-1).Date);

            var sb = new StringBuilder();

            sb.AppendLine("Relatório Diário de Pedidos");
            sb.AppendLine("------------");
            sb.AppendLine($"Date: {DateTime.Now.ToShortDateString()}");
            sb.AppendLine();

            foreach (var order in lastDayOrders)
            {
                sb.AppendLine($"ID: {order.Id}");
                sb.AppendLine($"Data: {order.Data.ToShortDateString()}");
                sb.AppendLine($"Total: {order.TotalAmount:C}");
                sb.AppendLine($"Cliente: {order.CustomerEmail}");
                sb.AppendLine($"Status: {order.StateDescription}");
                sb.AppendLine("------------");
            }

            var message = sb.ToString();
            _mercadinhoBemApp.OwnerEmailNotification.Notify(message, "Relatório Diário de Pedidos");
        }

        static void StartScheduleDailyReport()
        {
            System.Windows.Forms.Timer timer = new();
            timer.Interval = (int)TimeSpan.FromDays(1).TotalMilliseconds;
            timer.Tick += ScheduleDailyReport;
            timer.Start();
        }
    }
}