// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Enter your number: ");
double numberA = Convert.ToDouble(Console.ReadLine());
double numberB = numberA % 2;
if (numberB == 0) Console.WriteLine("Your number is even");
if (numberB != 0) Console.WriteLine("Your number is odd");
//Console.WriteLine(numberB);