namespace DayFive.Assigment;
public abstract class Appliance
{
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Power { get; set; }
    public abstract void TurnOn();
}

public class WashingMachine : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Washing machine is now on.");
    }
}

public class Refrigerator : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Refrigerator is now on.");
    }
}

