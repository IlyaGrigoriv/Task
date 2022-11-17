// 16. Напишите программу, 
// 1 которая принимает на вход два числа 
// 2 и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.WriteLine("Ввидите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool MethodSquare(int num1, int num2)
{
    return ((num1 * num1 == num2) | (num2 * num2 == num1)) ;
}
Console.WriteLine(MethodSquare(number1, number2) ? "Да" : "нет");

// if ((number1 * number1 == number2) | (number2 * number2 == number1))
// Console.WriteLine("да ");

// else Console.WriteLine("нет");
