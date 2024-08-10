using DayThree;

namespace DayTwo;
internal class Program
{
    static void Main(string[] args)
    {

        #region Array
        int[] numbers = [10, 20, 30, 40, 50];

        Student[] students = [new(string.Empty, 1, 12), new(string.Empty, 1, 12)];
        new StudentGrade().Print(numbers);
        ///Collection Of Elements Of The Same Types 
        /// ['l','o','c','a','l']
        /// Fixed Size [60] => new [60]
        /// 
        #endregion

        #region String

        //Immutable Reference Type (Reference Type Treat Like Value Type ) 
        //Animal animalOne = new("cat", 16);

        //Animal animalTwo = animalOne;

        //Console.WriteLine(animalOne);
        //Console.WriteLine(animalTwo);

        //animalTwo.Age = 20;

        //Console.WriteLine(animalOne);
        //Console.WriteLine(animalTwo);
        //string firstString = "local";
        //string secondString = firstString;
        //Console.WriteLine(firstString);
        //Console.WriteLine(secondString);

        //secondString = secondString + " name";
        //Console.WriteLine(firstString);
        //Console.WriteLine(secondString);

        //secondString += " variable";

        //StringBuilder stringBuilder = new(secondString);
        //for (int i = 0; i < 1000000; i++)
        //{
        //    stringBuilder.Append(i);
        //    Console.WriteLine(stringBuilder);
        //}
        //Console.ReadKey(); 
        #endregion


    }
    static int AddThenMultiply(int x, int y)
    {
        return MultiplyBy2(x + y);
    }

    static int MultiplyBy2(int addedValue)
    {
        return addedValue * 2;
    }

    static long Factorial(int number)
    {
        if (number <= 1) return 1;
        return number * Factorial(number - 1);
    }


}
