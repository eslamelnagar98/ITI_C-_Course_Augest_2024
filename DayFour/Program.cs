#region Record
//var point = new Point(10, 20);
//var anotherPoint = new Point(10, 20);

//var point2 = point;

//Console.WriteLine(point.Equals(null));
//Console.WriteLine(point.Equals(anotherPoint));
//Console.WriteLine(point.Equals(point2));
//Console.WriteLine(point == anotherPoint);

//var order = new OrderId() { Id = 10 };

//var pointRecord1 = new PointRecord(10, 20);
//var pointRecord2 = new PointRecord(10, 20);
//var pointRecord3 = pointRecord2 with { X = 15 };
//Console.WriteLine($"Is PointRecord1 Equal PointRecord2 :{pointRecord1.Equals(pointRecord2)}");
//Console.WriteLine($"Is PointRecord1 Equal PointRecord2 :{pointRecord1 == pointRecord2}");
//Console.WriteLine(pointRecord1);

//OrderId orderId = (OrderId)20;

//FromOrderIdToId(order);
//static void FromOrderIdToId(int id)
//{

//} 
#endregion

#region Ref,Out,In
//var x = 10;

//TryAdd(ref x, out var value, new Size(10));

//Console.WriteLine(value);

//// out is write only 

////in readonly operation
//static bool TryAdd(ref int numberTobeAdded, out int finalValue, in Size size)
//{
//    var w = size.X;

//    finalValue = ++numberTobeAdded + w;


//    return true;
//}

//public struct Size(int x)
//{
//    public int X { get; set; } = x;
//}
#endregion

#region Pass Reference Type By Value , By Reference
//using System.Text.Json;

//int[] numbers = [10, 20, 3, 30, 40, 50];

//TestPassingReferenceType(ref numbers);

//Console.WriteLine(JsonSerializer.Serialize(numbers));

//static void TestPassingReferenceType(ref int[] numbers)
//{
//    numbers[5] = 60;

//    numbers = new int[numbers.Length];
//} 
#endregion

#region ParamArray
//LogMessage("New Object Created");
//static void LogMessage(string message, params string[] @params)
//{
//    Console.WriteLine(message);
//    for (int i = 0; i < @params.Length; i++)
//    {
//        Console.WriteLine(@params[i]);
//    }
//}

//LogMessageExplicit("New Object Created", ["", ""]);
//static void LogMessageExplicit(string message, string[] @params)
//{
//    Console.WriteLine(message);
//    for (int i = 0; i < @params.Length; i++)
//    {
//        Console.WriteLine(@params[i]);
//    }
//} 
#endregion

#region Enums
//using DayFour;

//var day = 1;
//if (day == (int)DaysOfWeek.Sunday)
//{
//	Console.WriteLine("Sunday");
//}

//var state = "Success";

//var x = Enum.Parse(typeof(Status), state);
//Console.WriteLine(x);

#endregion



