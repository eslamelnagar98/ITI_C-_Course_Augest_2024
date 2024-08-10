using System;
namespace DayThree;
public sealed class Student
{
    private static int count = 0;

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    private static Student _instance = null;

    static Student()
    {
        Console.WriteLine("Static Ctor");
    }


    public void GetCount() => Console.WriteLine(count);

    public Student(int id) : this(id, string.Empty)
    {

    }

    public Student() : this(0, string.Empty)
    {
    }

    public static Student Create(int id, string name)
    {
        _instance ??= new Student(id, name);
        return _instance;
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


