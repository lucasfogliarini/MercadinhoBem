using System.Diagnostics.CodeAnalysis;

namespace MercadinhoBem.Domain.Products
{
    [ExcludeFromCodeCoverage]
    public class Product(int id, string name, decimal price, int quantity)
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
        public decimal Price { get; } = price;
        public int Quantity { get; set; } = quantity;
    }
}
