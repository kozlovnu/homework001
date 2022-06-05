// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter your number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 2;

while (numberB < numberA)
{
    if (numberB % 2 == 0)
    {
        //numberB = 2;
        Console.Write(numberB);
        Console.Write(", ");
        numberB = numberB + 2;
    }

    //else
    //{
    //    count ++;
    //}
}
if (numberA % 2 == 0)
{
    Console.WriteLine(numberA);
}