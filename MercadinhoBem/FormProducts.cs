using MercadinhoBem.Domain.Customers;

namespace MercadinhoBem
{
    public partial class FormProducts : Form
    {
        readonly FormOrder _formOrder;
        readonly IEnumerable<Product> _products = ProductRepository.GetProducts();

        public FormProducts(FormOrder formOrder)
        {
            InitializeComponent();

            dgvProducts.DataSource ??= _products;

            dgvProducts.AutoGenerateColumns = false;

            this._formOrder = formOrder;
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var productId = Convert.ToInt32(dgvProducts[colId.Index, e.RowIndex].Value);
            var product = _products.FirstOrDefault(e => e.Id == productId);

            _formOrder.AddItem(product);
        }
    }
}
