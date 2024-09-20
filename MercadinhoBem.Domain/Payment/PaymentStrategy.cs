using MercadinhoBem.Domain.Orders;
using System.Diagnostics.CodeAnalysis;

namespace MercadinhoBem.Domain.Payment
{
    public abstract class PaymentStrategy
    {
        [ExcludeFromCodeCoverage]
        public abstract string Description { get; }
        public virtual bool Pay(Order order)
        {
            Random random = new();
            int attempts = 0;

            while (attempts < 3)
            {
                Thread.Sleep(1000);
                attempts++;
                int chance = random.Next(0, 3);

                if (chance == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Falha ao realizar o pagamento na tentantiva {attempts}, tentando novamente ...");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Pagamento realizado com sucesso");
                    Console.ResetColor();
                    return true;
                }
            }

            return false;
        }
        public virtual decimal ApplyDiscount(decimal amount)
        {
            return 0;
        }
    }
}
