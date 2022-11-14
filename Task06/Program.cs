// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Ввидите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result =  a % 2;  // остаток больше 0 то
if ( result == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

// int a = 16;
// int result = a % 2 ;
// Console.WriteLine(result);
// double b = a;
// double result2 = b / 2 ;
// Console.WriteLine(result2);
// 4 -> да
// -3 -> нет
// 7 -> нет