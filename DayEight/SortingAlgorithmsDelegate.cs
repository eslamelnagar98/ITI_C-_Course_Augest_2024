namespace DayEight;

// delegate return SortingComapre(int firstNumber,int secondNumber)
public delegate bool SortingComparison(int x, int y);
public delegate bool NumberPredicate(int number);
public class SortingAlgorithmsDelegate
{
    public static void BubbleSort(int[] array, SortingComparison sortingComparison)
    {
        var size = array.Length;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                if (sortingComparison?.Invoke(array[j], array[j + 1]) ?? false)
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
