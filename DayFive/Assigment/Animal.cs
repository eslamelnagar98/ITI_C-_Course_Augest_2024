namespace DayFive.Assigment;
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

public class Zoo
{
    public static void DemonstratePolymorphism()
    {
        Animal[] animals = [new Dog(), new Cat()];
        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }
}

