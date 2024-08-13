namespace DayFour;
public class ScheduleChecker
{
    public string CheckDay(DayOfWeek day)
    {
        return day switch
        {
            DayOfWeek.Saturday or DayOfWeek.Sunday => "It's a weekend.",
            _ => "It's a weekday."
        };
    }

}
