/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

System.Console.WriteLine("Задача 2:");

System.Console.Write("Enter number 1: ");

int First_Number = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter number 2: ");

int Last_Number = Convert.ToInt32(Console.ReadLine());

if (First_Number > Last_Number)
{
    System.Console.Write("max: ");
    System.Console.WriteLine(First_Number);
    System.Console.Write("min: ");
    System.Console.WriteLine(Last_Number);
}
else
{
    System.Console.Write("max: ");
    System.Console.WriteLine(Last_Number);
    System.Console.Write("min: ");
    System.Console.WriteLine(First_Number);
}
    

