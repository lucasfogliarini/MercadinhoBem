namespace MercadinhoBem.Domain.Products
{
    public class ProductRepository
    {
        public static List<Product> GetProducts()
        {
            return
            [
                new(1, "Feijão", 6, 6),
                new(2, "Arroz", 4, 5),
                new(3, "Queijo", 10, 5),
                new(4, "Presunto", 5, 1),
            ];
        }
    }
}
