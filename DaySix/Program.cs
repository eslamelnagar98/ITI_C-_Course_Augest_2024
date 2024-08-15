#region Boxing And UnBoxing
//Log("The Value Of String is", "");
//Log("The Value Of Int is", 1);
//Log("The Value Of Short Is", (short)1);
//Log("The Value Of DateIs Is", DateTime.Now);
//Log("The Value Of DateIs Is", null);

//int number = 15;

//object @object = number;

//var number2 = (DateTime)@object;
//int x = 10;

//var @object = (object)x;

//var j = (int)@object;

//// Object Generic Way For passing Any Datatype 

//// Object Store Heap

//// String => Immutable Refreence Type (Address Stack Point To reference Heap)

//// Int => Value Type Stored In Stack With Storing 4 Bytes 
//// Converting Int (Value Type Stack) To Object Which Is Refrence Type Stored In Heap


//int number = 42; // Value Type Stored At The Stack 
//object @object1 = number; // Boxing , Number Is Now Stored On The Heap As An System.Object 

//object @object2 = 42; // Storing Heap
//int number2 = (int)@object2; // Unboxing , The Value Is Retrived And Placed On the Stack


//static void Log(string message, object param)
//{
//    var y = (decimal)param;
//    Console.WriteLine($"{message}:{param}");
//} 
#endregion

#region Handling Inputs

//var input = Console.ReadLine();
//if (string.IsNullOrWhiteSpace(input))
//{
//    return;
//}

//if (int.TryParse(input, out var value))
//{
//    Console.WriteLine(value);
//}
//else
//{
//    Console.WriteLine("Not Pusable String Value ");
//}

#endregion

#region Nullable Value Types
//int? nullableInt = null;

//int? nullableInt32 = 30;

////int y = (int)nullableInt;

////double? flag = null;

////double? NullableDouble = 454551.45;

////if (nullableInt.HasValue && nullableInt32.HasValue)
////{
////    int x = nullableInt.Value;
////    int y = nullableInt32.Value;
////    var result = Add(x, y);
////    var g = result.HasValue ? result.Value : 0;
////    Console.WriteLine(@$"Result Is {g}");
////}

//var result = Add(nullableInt ?? 10, nullableInt32.GetValueOrDefault(default));

//Console.WriteLine(@$"Result Is {result}");

//string str = "Ahmed";
//Console.WriteLine(str?.Length ?? 0);

//static int? Add(int x, int y)
//{
//    return x + y;
//} 
#endregion

#region Box Example For Generic 
//		var integerBox = new Box<int>(20);
//var integerValue = integerBox.GetValue();
//Console.WriteLine(integerValue);

//var stringBox = new Box<string>(string.Empty);
//var stringValue = stringBox.GetValue();
//Console.WriteLine(stringValue);

//var decimalBox = new Box<decimal>(decimal.Zero);
//var decimalValue = decimalBox.GetValue();
//Console.WriteLine(decimalValue); 
#endregion

#region Generics
//var calculator = new Calculator<int>();
//Console.WriteLine(calculator.Add(10, 20));

//var calculator2 = new Calculator<decimal>();
//var calculator3 = new Calculator<long>();
//var calculator4 = new Calculator<short>(); 
#endregion

#region Boxing And Unboxing
//var shoppingCart = new ShoppingCart();
//shoppingCart.Add("");
//shoppingCart.Add(null);
//shoppingCart.Add(10);
//shoppingCart.Add(decimal.Zero);
//shoppingCart.Add(0L);
//shoppingCart.Add((short)0);

//var array = shoppingCart.GetAll();

//for (int i = 0; i < array.Count; i++)
//{
//    var item = (int)array[i];
//    Console.WriteLine(item);
//} 
#endregion




