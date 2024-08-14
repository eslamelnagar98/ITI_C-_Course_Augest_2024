namespace DaySix;
public interface IEntity
{
    int Id { get; }
}

public class Customer : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Product : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}