#region List
//List<int> numbers = new(5) { 1, 2 };
//Console.WriteLine(string.Join(',', numbers));
//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//Console.WriteLine("Using Foreach");
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}


//var filterdElemnts = numbers.Where(i => i > 2);

//Console.WriteLine(string.Join(',', filterdElemnts));

//for (int i = 0; i < numbers.Count; i++)
//{
//    if (numbers[i] > 2)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}

//numbers.Remove(5);
//numbers.AddRange([8, 9, 10]);

//Console.WriteLine(string.Join(",", numbers)); 
#endregion

#region CircularBuffer Custome Collection
//var cicularBuffer = new CicularBuffer<int>(30)
//{
//    1,
//    2,
//    3,
//    4, 5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,
//};

//foreach (var item in cicularBuffer.Take(3))
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("Print GetAllData");
//foreach (var item in cicularBuffer.GetAllData().Take(3))
//{
//    Console.WriteLine(item);
//}

//var numbers = new List<int>(2000) { 1, 2, 3, 4, 5, 6, 7, 8 };
//var filterdData = numbers.Where(x =>
//{
//    Console.WriteLine($"value Of X In Where {x}");
//    return x % 2 == 0;
//})
//.Select(x => { Console.WriteLine($"Value Passed Through Select {x}"); return x; })
//.Take(2);

//Console.WriteLine(string.Join(',', filterdData)); 
#endregion

#region Deferred Vs Imediate Exceution
//var employees = new List<Employee>()
//{
//    new Employee{Id=1001,Name="Islam",Salary=90000 },
//    new Employee{Id=1002,Name="Ahmed",Salary=8000 },
//    new Employee{Id=1003,Name="Mohamed",Salary=8000 },
//};

//var result = employees.Where(x => x.Salary == 8000).ToList();

//employees.Add(new Employee { Id = 1004, Name = "Ahmed", Salary = 8000 });

//var resultTwo = employees.Where(x => x.Salary == 8000).ToList();

//foreach (var employee in result)
//{
//    Console.WriteLine(employee);
//}

//Console.WriteLine("Result Two");
//foreach (var employee in resultTwo)
//{
//    Console.WriteLine(employee);
//}

#endregion

#region Demonstrate The Idea Of Basic Methods Of Dictionary
//using DaySeven;

//Dictionary<string, Book> dictionary = new Dictionary<string, Book>()
//{
//    { "978-10101",new ("Clean Code","Robert C. Martin" ) },
//    { "978-10102",new ("C# In A NutSheel","Andrew Hunt" ) }
//};

//foreach (var book in dictionary)
//{
//    Console.WriteLine($"Key For This Book Is {book.Key},value Is {book.Value}");
//}

//dictionary["978-10103"] = new Book("Domain Driven Desin", "Eric Evans");
////Console.WriteLine(dictionary["978-10104"]);

//foreach (var book in dictionary)
//{
//    Console.WriteLine($"Key For This Book Is {book.Key},value Is {book.Value}");
//}

//dictionary.TryGetValue("978-10104", out var value);
//Console.WriteLine(value is null ? "No Book Found" : value);

//if (!dictionary.ContainsKey("978-10108"))
//{
//    dictionary.Add("978-10108", new Book(string.Empty, string.Empty));
//}
//Console.WriteLine(string.Join(',', dictionary.Keys)); 
#endregion

#region Dictionary
//using DaySeven;

//var firstPerson = new Person("Islam", "El-Naggar");
//var secondPerson = new Person("Mohamed", "Nassar");

//var peopleDictionary = new Dictionary<Person, string>
//{
//    {firstPerson,"Developer" },
//    {secondPerson,"Designer" },
//};

//var thirdPerson = new Person("Mohamed", "Nassar");

//Console.WriteLine($"HashCode For Person {firstPerson.GetHashCode()}");
//Console.WriteLine($"HashCode For Person {secondPerson.GetHashCode()}");
//Console.WriteLine($"HashCode For Person {thirdPerson.GetHashCode()}");

////peopleDictionary.TryGetValue(firstPerson, out var person);
////Console.WriteLine(person);

//peopleDictionary.Add(thirdPerson, "Engineer");

//foreach (var item in peopleDictionary)
//{
//    Console.WriteLine($"{item.Value}");
//}

#endregion

#region HashSet
//using DaySeven;

//var firstBook = new Book("Clean Code", "Robert C. Martin");

//var secondBook = new Book("C# In A NutSheel", "Andrew Hunt");

//var thirdBook = firstBook;

//var FouthBook = new Book("Student", "Isalm Elnaggar");

//var fifthBook = new Book("Student", "Isalm Elnaggar");

//var hashet = new HashSet<Book>() { firstBook, secondBook };

//Console.WriteLine(hashet.Add(FouthBook));
//Console.WriteLine(hashet.Add(fifthBook));

//Console.WriteLine(string.Join(',', hashet.ToList()));

//var list = new List<int>() { 1, 1, 1, 2, 2, 2, 3, 3, 3 };

//Console.WriteLine(string.Join(',', list.ToHashSet())); 
#endregion


List<int> numbers = new List<int> { 5, 3, 8, 1, 9, 2, 7 };

// Sorting the list in ascending order
List<int> sortedNumbers = SortAscending(numbers);
PrintList("Sorted Numbers (Ascending):", sortedNumbers);

// Filtering the list to only include even numbers
List<int> evenNumbers = GetEvenNumbers(numbers);
PrintList("Even Numbers:", evenNumbers);

static List<int> SortAscending(List<int> numbers)
{
    numbers.Sort();
    return numbers;
}

static List<int> GetEvenNumbers(List<int> numbers)
{
    List<int> result = new List<int>();
    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            result.Add(number);
        }
    }
    return result;
}

static void PrintList(string message, List<int> numbers)
{
    Console.WriteLine(message);
    foreach (var number in numbers)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}
public class Base
{
    public int BaseValue { get; set; }

    public void ShowBase() => Console.WriteLine("Base method");
}

public class Derived : Base
{
    public int DerivedValue { get; set; }

    public void ShowDerived() => Console.WriteLine("Derived method");
}

