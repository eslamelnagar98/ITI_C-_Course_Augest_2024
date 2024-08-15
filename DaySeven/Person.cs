namespace DaySeven;
//public class Person : IEquatable<Person>
//{
//    public string FirstName { get; set; } = string.Empty;
//    public string LastName { get; set; } = string.Empty;

//    public bool Equals(Person? other)
//    {
//        if (ReferenceEquals(other, null)) return false;
//        if (ReferenceEquals(other, this)) return true;
//        if (other.GetType() != GetType()) return false;

//        return other.FirstName == FirstName && other.LastName == LastName;
//    }
//    public override bool Equals(object? obj)
//    {
//        return Equals(obj as Person);
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(FirstName, LastName);
//    }

//    public override string ToString() => $"First Name:{FirstName}, Last Name: {LastName}";
//}

public record Person(string FirstName,string LastName);
