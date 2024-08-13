namespace DayFive;
public class PaypalPaymentProcessor : PaymentProcessor, IPaymentProcessor
{
    public void ProcessPaymentAdvanced(decimal amount)
    {
        Console.WriteLine($"Processing Paypal Payment Of {amount:c}, From Interface");
    }

    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing Paypal Payment Of {amount:c}, From Abstarct Class");
    }


}
