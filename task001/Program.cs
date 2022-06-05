// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("Enter the first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("Max number = ");
    Console.WriteLine(numberA);
}
else
{
    Console.Write("Max number = ");
    Console.WriteLine(numberB);
}