namespace MercadinhoBem.Domain.Customers
{
    public class Customer(string name, string email)
    {
        public string Name { get; set; } = name;
        public string Email { get; set; } = email;
    }
}
