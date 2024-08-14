namespace DayFive.Assigment;
public class Student
{
    private string _name;
    private int _age;
    private int _grade;

    public Student(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public void UpdateGrade(int grade)
    {
        if (grade < 0 || grade > 100)
        {
            throw new ArgumentException("Grade must be between 0 and 100.");
        }

        _grade = grade;
    }

    public int GetGrade()
    {
        return _grade;
    }
}

