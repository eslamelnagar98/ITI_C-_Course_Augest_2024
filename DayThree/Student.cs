using System;
namespace DayThree;
public sealed class Student
{
    private static int count = 0;
    private static Student _instance = null;
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public void GetCount() => Console.WriteLine(count);
    static Student()
    {
        Console.WriteLine("Static Ctor");
    }

    public Student(int id) : this(id, string.Empty) { }

    public Student() : this(0, string.Empty) { }

    public static Student Create(int id, string name)
    {
        try
        {
            if (count > 1)
            {
                throw new ArgumentOutOfRangeException("count");
            }

            return new Student(id, name);
        }
        catch (ArgumentOutOfRangeException _)
        {
            Console.WriteLine("There Is Exception In Create");
            throw;
        }
    }


    private Student(int id, string name)
    {
        Console.WriteLine("Instance Ctor");

        IdValidator(id);

        Name = name + "local";
        count++;
    }

    private void IdValidator(int id)
    {
        if (id < 15)
        {
            Id = 0;
        }
        else
        {
            Id = id;
        }
    }

    public void Add(int x, int y)
    {
        Id++;
    }

    public void Add(int x, int y, int z = 0)
    {
        x++;
        y++;
    }
    public void Print(string objectName = nameof(Student))
    {
        Console.WriteLine($"Message For Instance Of Type {objectName}");
    }

}

public class Product
{
    private string productName;
    private double price;
    private int quantity;
    public string ProductName { get => productName; set { productName = value; } }


    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
            else
                throw new ArgumentException("Price cannot be negative.");
        }
    }

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value >= 0)
                quantity = value;
            else
                throw new ArgumentException("Quantity cannot be negative.");
        }
    }

    public void UpdateQuantity(int additionalQuantity = 1)
    {
        Quantity += additionalQuantity;
    }
}
public static class ProductManager
{
    private static int instanceCount = 0;
    private static int maxInstances = 3;

    public static Product CreateProduct(string productName, double price, int quantity)
    {
        if (instanceCount >= maxInstances)
        {
            throw new InvalidOperationException("Cannot create more than 3 products.");
        }

        instanceCount++;
        return new Product
        {
            ProductName = productName,
            Price = price,
            Quantity = quantity
        };
    }
}


