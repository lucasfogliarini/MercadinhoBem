using MercadinhoBem.Domain.Orders;
using MercadinhoBem.Domain.Payment;
using MercadinhoBem.Domain.Products;
using MercadinhoBem.Domain.Customers;
using System.ComponentModel;

namespace MercadinhoBem
{
    public partial class FormOrder : Form
    {
        const int PixDiscountPercentage = 5;

        public Order Order { get; init; }
        public FormOrder(Order order)
        {
            InitializeComponent();
            Order = order;

            txtId.Text = Order.Id;
            cbCustomers.DataSource = CustomerRepository.GetCustomers();
            txtTotalAmount.Text = $"R${order.CalculateTotalAmount()}";
            txtState.Text = Order.State.Description;
            btnNext.Text = Order.State.NextStateDescription;
            txtData.Text = Order.Data.ToString();
            dgvOrderItems.AutoGenerateColumns = false;
            dgvOrderItems.DataSource = new BindingList<OrderItem>(Order.Items);
        }

        public void AddItem(Product product, int quantity = 1)
        {
            Order.AddItem(product, quantity);
            dgvOrderItems.DataSource = new BindingList<OrderItem>(Order.Items);
            txtTotalAmount.Text = $"R${Order.CalculateTotalAmount()}";

            MessageBox.Show($"{product.Name} adicionado ao pedido.");
        }

        private void dgvOrderItems_DoubleClick(object sender, EventArgs e)
        {
            new FormProducts(this).Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            TryProcess(Order.Next);
            StateChanged();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TryProcess(Order.Cancel);
            StateChanged();
        }

        private void StateChanged()
        {
            txtState.Text = Order.State.Description;
            btnNext.Visible = Order.State.NextStateDescription != null;
            btnNext.Text = Order.State.NextStateDescription;
        }

        private void TryProcess(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPagamento.SelectedIndex == (int)PaymentMethod.Pix)
            {
                Order.PaymentStrategy = new PixPaymentStrategy(PixDiscountPercentage);
            }
            else if (cbPagamento.SelectedIndex == (int)PaymentMethod.CreditCard)
            {
                Order.PaymentStrategy = new CreditCardPaymentStrategy();
            }
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.CustomerEmail = cbCustomers.SelectedValue?.ToString();
        }
    }
}
