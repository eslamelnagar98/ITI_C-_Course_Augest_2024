namespace DayFive;
public interface IPaymentProcessor
{
    void ProcessPaymentAdvanced(decimal amount);
    void LogPayment(decimal amount)
    {
        Console.WriteLine($"Logging Payment Of amount {amount:c}");
    }
}

public abstract class PaymentProcessor
{
    public abstract void ProcessPayment(decimal amount);
}
