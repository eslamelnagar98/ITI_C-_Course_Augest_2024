namespace DayFive;
internal class BankAccount(string accountNumber, decimal balance)
{
    internal decimal Balance { get; private set; } = balance;
    internal string AccountNumber => accountNumber;
    public void Deposite(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(amount, 0);

        Balance += amount;

        Console.WriteLine($"Deposite {amount:c}. New Balance Is {Balance:c}");
    }

    public void Withdraw(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(amount, 0);

        if (amount > Balance)
        {
            throw new InvalidOperationException("InSufficient Funds For This Withdraw");
        }

        Balance -= amount;
        Console.WriteLine($"Withdraw {amount:c}. New Balance Is {Balance:c}");
    }

    public void Transfer(BankAccount targetAccount, decimal amount)
    {
        ArgumentNullException.ThrowIfNull(targetAccount, nameof(targetAccount));
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(amount, 0);
        if (amount > Balance)
        {
            throw new InvalidOperationException("InSufficient Funds For This Transfer");
        }

        Withdraw(amount);

        targetAccount.Deposite(amount);

        Console.WriteLine($"Transferred Amount {amount:c} From Account {AccountNumber} To Account {targetAccount.AccountNumber},Your New Balance Is {Balance:c}.");
    }

}
