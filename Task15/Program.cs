// Задача 15: Напишите программу, 
// 1 которая принимает на вход цифру, 
// 2 обозначающую день недели, 
// 3 и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Ввидите число от 1-7 обозначающий день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
void Metod4(int num)
{
    if (num < 6 || num > 7) System.Console.WriteLine("Нет");
    if (num == 7 || num == 6) System.Console.WriteLine("Да");
    if (num > 7) System.Console.WriteLine("Такого дня недели не существует:");
}
Metod4(number);














// Console.WriteLine("Ввидите число дня недели: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 7 || num ==6 ) Console.WriteLine("да");
// if (num <6 )  Console.WriteLine("нет");
// if (num == 1)
// Console.WriteLine("Понедельник");
// else if (num == 2)
// Console.WriteLine("Вторник");
// else if (num == 3)
// Console.WriteLine("Среда");
// else if (num == 4)
// Console.WriteLine("Четверг");
// else if (num == 5)
// Console.WriteLine("Пятница");
// else if (num == 6)
// Console.WriteLine("Суббота");
// else if (num == 7)
// Console.WriteLine("Воскресенье");
// else Console.WriteLine("Такого дня недели нет ");