// Задача 40: Напишите программу, 
// 1 которая принимает на вход три числа 
// 2 и проверяет, может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон. 

Console.WriteLine("Вивидите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вивидите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вивидите число 3");
int number3 = Convert.ToInt32(Console.ReadLine());

bool TriangleCheck(int num1, int num2, int num3)
{
return (num1+num2 > num3 & num3+ num2> num1 & num1 + num3> num2) ;
}
System.Console.WriteLine(TriangleCheck(number1,number2,number3)? "Да": "Нет");
