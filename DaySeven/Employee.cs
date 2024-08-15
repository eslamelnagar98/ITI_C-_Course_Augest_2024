namespace DaySeven;
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Salary { get; set; }

    public override string ToString()
    {
        return $"Id:{Id},Name:{Name},Salary:{Salary}";
    }
}
