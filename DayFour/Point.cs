namespace DayFour;
public class Point(int x, int y) : IEquatable<Point>
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public override bool Equals(object obj)
    {
        return Equals(obj as Point);
    }

    public bool Equals(Point other)
    {
        if (ReferenceEquals(other, null)) return false;

        if (ReferenceEquals(other, this)) return true;

        return other.X == X && other.Y == Y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    public static bool operator ==(Point left, Point right)
    {
        if (left is null || right is null) return false;

        if (ReferenceEquals(left, right)) return true;

        return left.Equals(right);
    }

    public static bool operator !=(Point left, Point right) => !(left == right);
}

public record PointRecord(int X,int Y);



