namespace DayFive;
public class PaymentService(PaymentProcessor paymentProcessor, IPaymentProcessor processor)
{
    public void MakeMoney(decimal amount)
    {
        paymentProcessor.ProcessPayment(amount);

        processor.ProcessPaymentAdvanced(amount);
    }
}
