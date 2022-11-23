// Задача 28: Напишите программу. 
// 1 которая принимает на вход число N . 
// 2 выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
System.Console.WriteLine("ввидите число");
int number = Convert.ToInt32(System.Console.ReadLine());
int SumNumber(int num)
{
    int Sum = 1;
    for (int i = 1; i <= num; i++)
    {
        Sum = Sum * i;
    }
    return Sum;

}
int sumNumber = SumNumber(number);
System.Console.WriteLine($"{number} --> {sumNumber}");