// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int numb)
{
return numb != 0 ? numb % 10 + SumDigits(numb / 10) : 0;
}

Console.WriteLine(SumDigits(Math.Abs(number)));



//Console.WriteLine(temp);