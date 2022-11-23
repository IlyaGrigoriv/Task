// Задача 27: Напишите программу, 
// 1 которая принимает на вход число 
// 2 и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
System.Console.WriteLine("Ввидите число");
int A = Convert.ToInt32(System.Console.ReadLine());
if (A<0) A= -A;
int SumNumber(int num)
{
    int count = 1;
    int result1 = 0;
    int result2 = 0;
    int Sum = 0;

    for (int i = 0; count > 0; i++)
    {
        result1 = num % 10;  
        result2 = num / 10;
        Sum = result1 + Sum; 
        num = result2;
        count = num;
    }

    return Sum;
}
int sumNumber = SumNumber(A);
System.Console.WriteLine($"{A} -> {sumNumber}");