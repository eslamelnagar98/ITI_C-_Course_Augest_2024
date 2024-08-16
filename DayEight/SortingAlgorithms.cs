namespace DayEight;
public class SortingAlgorithms
{
    public static void BubbleSortAscsending(int[] array)
    {
        var size = array.Length;
        for (int i = 0; i < size; i++)
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

    public static void BubbleSortDescending(int[] array)
    {
        var size = array.Length;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                if (StaticComparisonLogic.CompareDescending(array[j], array[j + 1]))
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }
    public static void BubbleSortByAbsoulateValue(int[] array)
    {
        var size = array.Length;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                if (StaticComparisonLogic.CompareByAbsouluteValue(array[j], array[j + 1]))
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }

    private static void Swap(ref int a, ref int b)
    {
        var temp = a;
        a = b;
        b = temp;
    }
}


public static class StaticComparisonLogic
{
    public static bool CompareAscending(int x, int y) => x > y;
    public static bool CompareDescending(int x, int y) => x < y;
    public static bool CompareByAbsouluteValue(int x, int y) => Math.Abs(x) > Math.Abs(y);
}