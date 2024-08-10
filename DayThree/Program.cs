// Public Visible For The Same Asembly Or AnyOther Assembly Refrence This Assembly
//Internal :visible only inside any class with the same assembly
//Private: Visible Within The Same Class 
// Protected: Visible Only With In The Child Class either on the same assembly
// or any other child on the refrenced Assembly

using System;
using DayThree;

var student = Student.Create(10, "mohamed");
var student1 = Student.Create(10, "mohamed");
var student2 = Student.Create(10, "mohamed");
var student3 = Student.Create(10, "mohamed");



Console.WriteLine(student.GetHashCode());
Console.WriteLine(student1.GetHashCode());
Console.WriteLine(student2.GetHashCode());
Console.WriteLine(student3.GetHashCode());
student3.GetCount();
//student.Print();
//student7.GetCount();
