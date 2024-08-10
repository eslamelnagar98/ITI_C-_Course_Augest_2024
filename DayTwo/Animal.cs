namespace DayTwo;
public class Animal
{
    public Animal(string name,int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get;  set; }
    public int Age { get;  set; }
    public override string ToString()
    {
        return $"{Name} And {Age}";
    }
}

public struct AnimalStruct
{
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        return $"{Name} And {Age}";
    }
}
