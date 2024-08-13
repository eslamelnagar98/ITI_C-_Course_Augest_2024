namespace DayFour;
public class Logger
{
    public void LogMessage(string message, params object[] details)
    {
        Console.WriteLine(message);
        foreach (var detail in details)
        {
            Console.WriteLine(detail);
        }
    }

}
