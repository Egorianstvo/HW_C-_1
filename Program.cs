/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

System.Console.WriteLine("_____Задача 2_____");

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
    

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

System.Console.WriteLine("_____Задача 4_____");

System.Console.Write("Enter number 1: ");

int First_Number2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter number 2: ");

int Second_Number = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter number 3: ");

int Last_Number2 = Convert.ToInt32(Console.ReadLine());

if (First_Number2 > Second_Number && First_Number2 > Last_Number2)  
{
    System.Console.Write("Max number: ");
    System.Console.WriteLine(First_Number2);
}
else if (Second_Number > First_Number && Second_Number > Last_Number2)
{
    System.Console.Write("Max number: ");
    System.Console.WriteLine(Second_Number);
}
else
{
    System.Console.Write("Max number: ");
    System.Console.WriteLine(Last_Number2);
}


/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

System.Console.WriteLine("_____Задача 6_____");

System.Console.Write("Enter number:");

int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 2 == 0)
{
    System.Console.WriteLine("Четное!!!");
}
else 
{
    System.Console.WriteLine("Не четное!!!");
}