// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ввидите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите число 2: ");
int b = Convert.ToInt32(value: Console.ReadLine());
int max = 0;
int min = 0;
if (a == b) Console.WriteLine("Числа равны: "); // не работает если числа одинаковы

{
        if (a > b)
    {
        max = a;
        min = b;
    }
    else
    {
        max = b;
        min = a;
    }

}


Console.WriteLine($" Максимальное число {max}");
Console.WriteLine($" Минимальное число {min}");


