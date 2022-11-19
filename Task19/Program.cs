// Задача 19 Напишите программу, которая 
// 1 принимает на вход пятизначное число и 
// 2 проверяет, является ли оно палиндромом. 12321
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Ввидите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 9999 || number > 99999) System.Console.WriteLine("Ведено не правельное число");
int Palindrome(int num)
{
    int num2 = 0;
    if (num2 = num / 10) return num2;
}

bool palindrome = Palindrome(number);
Console.WriteLine(palindrome);