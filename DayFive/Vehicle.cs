namespace DayFive;
public class Vehicle(string make, string model, int year)
{
    public int Speed { get; set; }
    public string Make { get; set; } = make;
    public string Model { get; set; } = model;
    public int Year { get; set; } = year;
    public virtual void StartEngine()
    {
        Console.WriteLine("Vehicle Started");
    }
}


