namespace DaySix;
public class CalculatorObject
{
    public object Add(object a, object b)
    {
        if (a == null || b == null)
        {
            throw new ArgumentNullException(nameof(a));
        }

        if (a is int && b is int)
        {
            return (int)a + (int)b;
        }

        else if (a is double && b is double) { return (double)a + (double)b; }
        else
        {
            throw new InvalidOperationException();
        }
    }
}
