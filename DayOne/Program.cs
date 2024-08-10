namespace DayOne;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Factorial(4));
    }
    static int Add(int x, int y)
    {
        return x + y;
    }

    static long Factorial(int number)
    {
        if (number <= 1) return 1;
        return number * Factorial(number - 1);
    }

    ///4*3*2*1 => 4 Factoral (3)
    /// Fact 3 => 3 * Fact(2)
    ///Fact (2)=> 2 Fact(1)
}





//Value Type 



#region Integral Type 
//bytes 
// Byte => 8 Bits 0 - 255
//1   1   1 1  1 1 1 1

//128 64 32 16 8 4 2 1

//short => 2 Byte => 16 bit => 32000
//2 power -15 2 power 15

// Int => 4 Byte => 32 bit =>2,174

// long => 8 Byte => 64 => 9,223 Billion



// 
#endregion

#region Floating-Point Types 
// float => 4 Bytes => 32 bit Percison Floating Point 45415.656
//1 signed 23 bit hold value ()
// doublt => 8 Byte => 64 bit Percison Floating Point 16 Digit 
// decimal=> 16 Byte => 128 bit Percison decimal Point used financial

#endregion

#region Boolean
//true , False 
#endregion

#region charcters
// unicode code 
#endregion

#region Special Types 

//Datetime
//Dateonly
//Timespan
//Guid Globaly Unique Identifier 

#endregion

