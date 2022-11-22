// Задача 24: Напишите программу, которая
// 1 принимает на вход число (А) 
// 2 и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
System.Console.WriteLine("Ввидите число");
int number = Convert.ToInt32(System.Console.ReadLine());
int SumNumber(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int sumNumber = SumNumber(number);
System.Console.WriteLine($"{number}-->{sumNumber}");