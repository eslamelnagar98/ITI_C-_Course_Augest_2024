namespace DayThree;
public class BaseClass
{
    protected internal string ProtectedInternalMember { get; set; }

    public BaseClass()
    {
        ProtectedInternalMember = "Accessible in derived classes and within the same assembly";
    }
}
