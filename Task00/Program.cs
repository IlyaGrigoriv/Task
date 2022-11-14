// программу, которая 
// 1 . на вход принимает число и 
// 2 . выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49c

Console.WriteLine("Введение целое число: ");

int a = Convert.ToInt32(Console.ReadLine());
int square = a * a ;
Console.WriteLine($" Квадрат числа {a} = {square} ");   
