// Задача 66: 1 
// 1 Задайте значения M и N. 
// 2 Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int B = Convert.ToInt32(Console.ReadLine());
DegreeNumber(A,B);
int DegreeNumber(int A, int B)
{
    if (A > B) return 0;
    return A + DegreeNumber(A+1, B) ;
}
System.Console.WriteLine(DegreeNumber(A,B));