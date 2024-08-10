namespace DayTwo;
public struct Student(string name, int age, double gpa)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public double GPA { get; set; } = gpa;
    public override string ToString()
    {
        return $"Name: {Name},{Environment.NewLine} Age: {Age},{Environment.NewLine} GPA: {GPA:F2}";
    }
}
