namespace DaySix;
public class ShoppingCart
{
    private List<object> _objectArray = [];

    public void Add(object @object)
    {
        _objectArray.Add(@object);
    }

    public List<object> GetAll() => _objectArray;
}
