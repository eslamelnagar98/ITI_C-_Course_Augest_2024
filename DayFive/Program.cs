using DayFive;
using DayFive.Assigment;
#region Inheritance
//Car car = new Car("Toyota", "Corolla", 2022);

//Vehicle vehicle = new Vehicle("Toyota", "Corolla", 2022); 

//car.StartEngine();
#endregion

#region Encapsulation
//var account1 = new BankAccount("12345", 1000);
//var account2 = new BankAccount("67890", 500);

//account1.Deposite(200);
//account1.Withdraw(100);
//account1.Transfer(account2, 300);

#endregion

#region Interface, Abstract
//var paymentService = new PaymentService(new PaypalPaymentProcessor(), new PaypalPaymentProcessor());
//paymentService.MakeMoney(100);

//paymentService = new PaymentService(new CreditCardPaymentProcessor(), new CreditCardPaymentProcessor());
//paymentService.MakeMoney(50);

//paymentService = new PaymentService(new CachePaymentProcessor(), new CachePaymentProcessor());
//paymentService.MakeMoney(100); 
#endregion

// Encapsulation
var student = new Student("John", 20);
student.UpdateGrade(85);
Console.WriteLine($"{student.Name}'s grade: {student.GetGrade()}");

// Abstraction using Interfaces
var studentWithNotifier = new StudentWithNotifier("Jane", 22, new EmailNotifier());
studentWithNotifier.UpdateGrade(90);

// Inheritance and Polymorphism
Zoo.DemonstratePolymorphism();

// Abstraction using Abstract Classes
var washingMachine = new WashingMachine { Brand = "LG", Model = "WM5000HVA", Power = 500 };
var refrigerator = new Refrigerator { Brand = "Samsung", Model = "RF23M8570SG", Power = 400 };

washingMachine.TurnOn();
refrigerator.TurnOn();


