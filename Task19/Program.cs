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
else
{
void Palindrome(int numA1)
{
    int exam1 = numA1 / 10000; 
    int exam2 = numA1 % 10; 
    if (exam1 != exam2) System.Console.WriteLine("Число не палиндромна");
    else
    {
        int exam3 = numA1 / 1000; 
        int exam5 = exam3 % 10; 
        int exam4 = numA1 % 100; 
        int exam6 = exam4 / 10; 

        if (exam5 == exam6) System.Console.WriteLine("Число полиндромно");
        else
        {
            if (exam5 != exam6) 
            System.Console.WriteLine("Число не палиндромна");
        }
    }
}Palindrome(number);
}


