using DayThree;

namespace DayTwo;
public class StudentGrade
{
    public Course Course { get; set; }
    public string Name { get; set; }
    public short Grade { get; set; }
    public void Print(int[] numbers)
    {
        Console.Write("[");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers.Length - i == 1)
            {
                Console.Write(numbers[i]);
            }
            else
            {
                Console.Write(numbers[i] + ",");
            }
        }
        Console.Write("]");
    }
}
