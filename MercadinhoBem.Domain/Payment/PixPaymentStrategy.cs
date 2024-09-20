namespace MercadinhoBem.Domain.Payment
{
    public class PixPaymentStrategy(decimal discountPercentage) : PaymentStrategy
    {
        public override string Description => "Pix";

        readonly decimal _discountPercentage = discountPercentage;

        public override decimal ApplyDiscount(decimal amount)
        {
            var discount = amount * _discountPercentage / 100;
            return discount;
        }
    }
}
