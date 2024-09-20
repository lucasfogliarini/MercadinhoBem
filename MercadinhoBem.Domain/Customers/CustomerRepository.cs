namespace MercadinhoBem.Domain.Customers
{
    public class CustomerRepository
    {
        public static List<Customer> GetCustomers()
        {
            return
            [
                new(null, null),
                new("João", "joao@gmail.com"),
                new("Lucas", "lucas@gmail.com"),
                new("Maria", "maria@gmail.com"),
                new("Roberta", "roberta@gmail.com"),
            ];
        }
    }
}
