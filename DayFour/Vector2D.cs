namespace DayFour;
public class Vector2D : IEquatable<Vector2D>
{
    public double X { get; }
    public double Y { get; }

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public bool Equals(Vector2D? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return X == other.X && Y == other.Y;
    }

    public override bool Equals(object? obj) => Equals(obj as Vector2D);

    public override int GetHashCode() => HashCode.Combine(X, Y);

    public static Vector2D operator +(Vector2D left, Vector2D right)
    {
        return new Vector2D(left.X + right.X, right.Y + left.Y);
    }

    public static Vector2D operator -(Vector2D left, Vector2D right)
    {
        return new Vector2D(left.X - right.X, left.Y - right.Y);
    }

    public static Vector2D operator *(Vector2D left, double scalar)
    {
        return new Vector2D(left.X * scalar, left.Y * scalar);
    }

    public static bool operator ==(Vector2D? left, Vector2D? right)
    {
        if (ReferenceEquals(left, right)) return true;
        if (left is null || right is null) return false;
        return left.Equals(right);
    }

    public static bool operator !=(Vector2D? left, Vector2D? right) => !(left == right);

    public override string ToString() => $"Vector2D(X: {X}, Y: {Y})";
}
