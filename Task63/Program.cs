// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("В видите число ");
int Num = Convert.ToInt32(Console.ReadLine());

NaturalNumber(Num);
void NaturalNumber(int Num)
{
    if(Num ==0)return;
    //Console.Write($"{Num}-");   // 5 4 3 2 1
    NaturalNumber(Num-1);
    Console.Write($"{Num}-");     // 5 1 2 3 4

}


