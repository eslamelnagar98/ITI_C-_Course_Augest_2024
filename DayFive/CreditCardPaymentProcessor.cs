namespace DayFive;
public class CreditCardPaymentProcessor : PaymentProcessor, IPaymentProcessor
{
    public void ProcessPaymentAdvanced(decimal amount)
    {
        Console.WriteLine($"Processing Credit Payment Of {amount:c}, From Interface");
    }

    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing Credit Payment Of {amount:c}, From Abstarct Class ");
    }
}
