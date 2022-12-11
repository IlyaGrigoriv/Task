// Задача 64: 
// 1 Задайте значение N. 
// 2 Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("В видите число ");
int Num = Convert.ToInt32(Console.ReadLine());

NaturalNumber(Num);
void NaturalNumber(int Num)
{
    if(Num ==0)return;
    Console.Write($"{Num} ");   // 5 4 3 2 1
    NaturalNumber(Num-1);
    //Console.Write($"{Num}-");     // 5 1 2 3 4

}