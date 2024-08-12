namespace DayFour;
public class OrderId
{
    public int Id { get; set; }

    public static implicit operator int(OrderId orderId) => orderId.Id;

    public static explicit operator OrderId(int value) => new() { Id = value };
}
