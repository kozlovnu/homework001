// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Enter the first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (max < numberB) max = numberB;
if (max < numberC) max = numberC;
if (max < numberA) max = numberA;

Console.Write("Max number = ");
Console.WriteLine(max);