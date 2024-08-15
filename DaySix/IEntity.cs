namespace DaySix;
public interface IEntity
{
    int Id { get; }
}

public class Customer : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Product : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

public class Library : IEnumerable<Book>
{
    private List<Book> _books = new List<Book>();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return _books.GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
