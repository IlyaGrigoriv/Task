// Задача 13: Напишите программу, 
//  1 которая выводит третью цифру заданного числа 
//  2 или сообщает, что третьей цифры нет. 
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Ввидите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) Console.WriteLine("Третьей цифры нет");
int Metod3(int number)// не понимаю ошибку (не все пути к коду возвращают значение)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int c = 0;
    c = number % 10;
    Console.WriteLine(c);
}
int metod = Metod3(num);




// рабочий код без метода
// Console.WriteLine("Ввидите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100) Console.WriteLine("Третьей цифры нет");
// while (number > 999)
// {
//     number = number / 10;
// }
// int c = 0;
// c = number % 10;
// Console.WriteLine(c);


