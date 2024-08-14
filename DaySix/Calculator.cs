using System.Numerics;

namespace DaySix;
public class Calculator<T> where T : INumber<T>
{
    public T Add(T a, T b)
    {
        return a + b;
    }

    public T Subtract(T a, T b)
    {
        return a - b;
    }

    public T Multiply(T a, T b)
    {
        return a * b;
    }


    public T Divide(T a, T b)
    {
        return b == T.Zero
            ? throw new DivideByZeroException("Diivion By Zero Is Not Allower")
            : a / b;
    }
}

public class Point
{
    public Point(int x, int y)
    {

    }
}



