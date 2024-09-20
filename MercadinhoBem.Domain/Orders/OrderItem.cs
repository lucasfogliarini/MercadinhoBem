using MercadinhoBem.Domain.Products;

namespace MercadinhoBem.Domain.Orders
{
    public class OrderItem(Product product, int quantity)
    {
        public Product Product { get; } = product;
        public string? ProductName { get { return Product?.Name; } }
        public int Quantity { get; set; } = quantity;
        public decimal Total { get { return Quantity * Product.Price; } }
    } 
}
