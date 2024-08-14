namespace DayFive.Assigment;
public interface INotifier
{
    void SendNotification(string message);
}

public class EmailNotifier : INotifier
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

public class SMSNotifier : INotifier
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}

public class StudentWithNotifier
{
    private string _name;
    private int _age;
    private int _grade;
    private INotifier _notifier;

    public StudentWithNotifier(string name, int age, INotifier notifier)
    {
        _name = name;
        _age = age;
        _notifier = notifier;
    }

    public void UpdateGrade(int grade)
    {
        if (grade < 0 || grade > 100)
        {
            throw new ArgumentException("Grade must be between 0 and 100.");
        }

        _grade = grade;
        _notifier.SendNotification($"The grade has been updated to: {grade}");
    }

    public int GetGrade()
    {
        return _grade;
    }
}
