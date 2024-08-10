namespace DayTwo;
public class ClassTest
{
    private int x;
    private int y;
    private int result;
}

public class Person
{
    private string name; // Private field backing the property

    public string Name // Property with get and set accessors
    {
        get { return name; }
        set { name = value; }
    }

    private int age;

    public int Age // Property with validation in the set accessor
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
            else
                throw new ArgumentException("Age must be positive.");
        }
    }
}

public class Product
{
    public decimal Price { get; set; } // Simple property
}

// Later, you can add logic without changing how the property is accessed
public class Product2
{
    private decimal price;

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Price cannot be negative");
            price = value;
        }
    }
}

public class Person2
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Person2 other = (Person2)obj;
        return Name == other.Name && Age == other.Age;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }
}

public record Quote(string Token, int Id);
