using MercadinhoBem.Domain.Orders;
using System.ComponentModel;

namespace MercadinhoBem
{
    public partial class FormOrders : Form
    {
        public MercadinhoBemApp MercadinhoBemApp { get; }

        public FormOrders(MercadinhoBemApp mercadinhoBemApp)
        {
            InitializeComponent();
            MercadinhoBemApp = mercadinhoBemApp;
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.DataSource = new BindingList<Order>(MercadinhoBemApp.Orders);
        }

        private void menuCriarPedido_Click(object sender, EventArgs e)
        {
            var order = new Order(MercadinhoBemApp.CustomerEmailNotification, MercadinhoBemApp.Discounts);
            MercadinhoBemApp.Orders.Add(order);

            ShowFormOrder(order);
        }

        private void ShowFormOrder(Order order)
        {
            var formOrder = new FormOrder(order);
            formOrder.FormClosed += FormOrder_FormClosed;
            formOrder.Show();
        }

        private void FormOrder_FormClosed(object? sender, FormClosedEventArgs e)
        {
            var formOrder = (sender as FormOrder);
            formOrder.Order.CalculateTotalAmount();
            dgvOrders.DataSource = new BindingList<Order>(MercadinhoBemApp.Orders);
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var orderId = dgvOrders[colId.Index, e.RowIndex].Value.ToString();
                var order = MercadinhoBemApp.Orders.FirstOrDefault(e => e.Id == orderId);
                ShowFormOrder(order);
            }
        }
    }
}
