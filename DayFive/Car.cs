namespace DayFive;
public class Car(string make, string model, int year) : Vehicle(make, model, year)
{
    public int NumberOfDoors { get; set; }

    public new void StartEngine()
    {
        Console.WriteLine("Car Started");
        Add(10, 20, 30);
    }

    public double Add(int x, int y, double z = 10) => x + y + z;
    public int Add(int x, int y, int z = 0) => x + y + z;
}

