namespace DayFive;
public class CachePaymentProcessor : PaymentProcessor, IPaymentProcessor
{
    public void ProcessPaymentAdvanced(decimal amount)
    {
        Console.WriteLine($"Processing Cache Payment Of {amount:c},From Interface");
    }

    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing Cache Payment Of {amount:c}, From Abstract Class");
    }
}
