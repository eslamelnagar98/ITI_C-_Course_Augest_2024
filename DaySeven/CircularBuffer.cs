using System.Collections;

namespace DaySeven;
public class CircularBuffer<T>(int capacity) : IEnumerable<T>
{
    private readonly T[] _buffer = new T[capacity];
    private int _head = 0;

    public void Add(T item)
    {
        _buffer[_head] = item;
        _head = (_head + 1) % _buffer.Length;
    }
    public IEnumerator<T> GetEnumerator()
    {   
        for (int i = 0; i < _head; i++)
        {
            yield return _buffer[i];
        }
    }

    public IEnumerable<int> GetAllData()
    {
        var range = Enumerable.Range(0, 100000);
        foreach (var item in range)
        {
            yield return item;
        }
    }


    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
