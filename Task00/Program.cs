// программу, которая 
// 1 . на вход принимает число и 
// 2 . выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49c

Console.WriteLine("Введение целое число: ");

int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($" Квадрат числа {number} = {square} ");   
