using System;
namespace DayThree;
public class Point(int x, int y) : IEquatable<Point>
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public bool Equals(Point? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        if (GetType() != other.GetType()) return false;
        return X == other.X && Y == other.Y;
    }

    public override bool Equals(object? obj) => Equals(obj as Point);

    public override int GetHashCode() => HashCode.Combine(X, Y);

    void PrintNumbers(params int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public void LogMessage(string message, params object[] details)
    {
        try
        {
            Console.WriteLine(message);
            foreach (var detail in details)
            {
                Console.WriteLine(detail);
            }
        }
        catch (Exception exception) when (exception is ArgumentNullException or DivideByZeroException)
        {
            Console.WriteLine($"Processing failed: {exception.Message}");
            throw;
        }
    }

    public static bool operator ==(Point? left, Point? right)
    {
        if (ReferenceEquals(left, right)) return true;

        if (left is null || right is null) return false;

        return left.Equals(right);
    }

    public static bool operator !=(Point? left, Point? right) => !(left == right);

    public static int operator +(Point? left, Point? right) => left.X + right.X;

    public static Point operator ++(Point point)
    {
        point.X++;
        point.Y++;
        return point;
    }

    public static Point operator --(Point point)
    {
        point.X--;
        point.Y--;
        return point;
    }


    public static implicit operator int(Point point) => point.X;

    public static explicit operator Point(int x) => new(x, 10);


    public override string ToString() => $"Point(X: {X}, Y: {Y})";
}
public enum DaysOfWeek
{
    Sunday = 0,
    Monday = 6,
    Tuesday = 8,
    Wednesday = 10,
    Thursday = 11,
    Friday = 12,
    Saturday = 13,
}
public enum DaysOfWeek2
{
    None,
    Sunday,
    Monday,
}