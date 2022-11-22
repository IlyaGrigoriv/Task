// Задача 26: Напишите программу, 
//1 которая принимает на вход число и 
//2 выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
System.Console.WriteLine("Видите число");
int number = Convert.ToInt32(System.Console.ReadLine());

int NumLength(int num)
{
    int n = 1;
    for (int i = 0; i < 10; i++)
    {
        num = num / 10;
        if (num != 0) n++;
        else break;


    }
    return n;
}
int numLength= NumLength(number);
System.Console.WriteLine(numLength);

