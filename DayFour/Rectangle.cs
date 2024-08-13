namespace DayFour;
public class Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public void DoubleDimensionsByValue(Rectangle rectangle)
    {
        rectangle = new Rectangle(rectangle.Length * 2, rectangle.Width * 2);
    }

    public void DoubleDimensionsByRef(ref Rectangle rectangle)
    {
        rectangle = new Rectangle(rectangle.Length * 2, rectangle.Width * 2);
    }
    public override string ToString() => $"Rectangle(Length: {Length}, Width: {Width})";

}
