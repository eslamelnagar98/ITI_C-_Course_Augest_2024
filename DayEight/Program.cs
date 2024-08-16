//var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

//SortingAlgorithms.BubbleSortAscsending(numbers);
//SortingAlgorithms.BubbleSortDescending(numbers);
//SortingAlgorithms.BubbleSortByAbsoulateValue(numbers);

//SortingComparison sortingComparison = CompareByAbsouluteValueDescending;

//SortingAlgorithmsDelegate.BubbleSort(numbers, CompareByAbsouluteValueDescending);

//var x = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

//x.Where(x => x % 2 == 0);
//x.Where(x => x < 7);
//x.Where(x => x > 15);

//static bool CompareByAbsouluteValueDescending(int x, int y) => Math.Abs(x) < Math.Abs(y);
//public static class StaticComparisonLogic
//{
//    public static bool CompareAscending(int x, int y) => x > y;
//    public static bool CompareDescending(int x, int y) => x < y;
//    public static bool CompareByAbsouluteValue(int x, int y) => Math.Abs(x) > Math.Abs(y);
//}
#region Without Delegate
//var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

//Console.WriteLine(string.Join(',', GetNumbersDivisibleBy2(numbers)));
//Console.WriteLine(string.Join(',', GetNumbersDivisibleBy3(numbers)));
//static IEnumerable<int> GetNumbersDivisibleBy2(List<int> numbers)
//{
//    foreach (var number in numbers)
//    {
//        if (number % 2 == 0)
//        {
//            yield return number;
//        }
//    }
//}

//static IEnumerable<int> GetNumbersDivisibleBy3(List<int> numbers)
//{
//    foreach (var number in numbers)
//    {
//        if (number % 3 == 0)
//        {
//            yield return number;
//        }
//    }
//}

#endregion

//Func<T,Tout>
//Predicate<T,bool>
//Action<T>

using DayEight;

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
GetNumbers(numbers, number => number % 2 == 0, numbers => Console.WriteLine(string.Join(",", numbers)));
GetNumbers(numbers, number => number % 3 == 0, numbers => Console.WriteLine(string.Join(",", numbers)));

static List<int> GetNumbers(List<int> numbers, Func<int, bool> predicate, Action<List<int>> print)
{
    var result = new List<int>();
    foreach (int number in numbers)
    {
        if (predicate?.Invoke(number) ?? false) result.Add(number);
    }

    print(result);
    return result;
}

//var booList = numbers.Select(number => number % 2 == 0);
//Console.WriteLine(string.Join(',', booList));
//IEnumerable<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine("12335".ToNumber<double>(double.TryParse));



