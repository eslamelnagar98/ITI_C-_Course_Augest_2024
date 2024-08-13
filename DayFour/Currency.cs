namespace DayFour;
public class Currency
{
    public double Amount { get; set; }
    public string CurrencyCode { get; set; }

    public Currency(double amount, string currencyCode)
    {
        Amount = amount;
        CurrencyCode = currencyCode;
    }

    public static implicit operator Currency(double amount)
    {
        return new Currency(amount, "USD");
    }

    public static explicit operator double(Currency currency)
    {
        return currency.Amount;
    }

    public override string ToString() => $"{Amount} {CurrencyCode}";

}
