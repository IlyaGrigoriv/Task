// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Ввидите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0 ;

 while (count <= a )
{
    if (count < a)
    count = count + 2;
    if (count < a)
    {
    Console.WriteLine(count);
    }
    else break;
}





