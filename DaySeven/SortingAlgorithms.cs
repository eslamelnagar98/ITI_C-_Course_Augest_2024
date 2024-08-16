namespace DaySeven;
public static class SortingAlgorithms
{
    static void BubbleSortAscending(int[] array)
    {
        var size = array.Length;
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                if (StaticComparisonLogic.CompareAscending(array[j], array[j + 1]))
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }

    static void BubbleSortDescending(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (StaticComparisonLogic.CompareDescending(array[j], array[j + 1]))
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }

    static void BubbleSortByAbsoluteValue(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (StaticComparisonLogic.CompareByAbsoluteValue(array[j], array[j + 1]))
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void PrintArray(string message, int[] array)
    {
        Console.WriteLine(message);
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
public static class StaticComparisonLogic
{
    public static bool CompareAscending(int x, int y)
    {
        return x > y;
    }

    public static bool CompareDescending(int x, int y)
    {
        return x < y;
    }

    public static bool CompareByAbsoluteValue(int x, int y)
    {
        return Math.Abs(x) > Math.Abs(y);
    }
}
