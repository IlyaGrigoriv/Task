// Задача 43: Напишите программу,
// 1 которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Ввидите число 1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите число 2");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите число 3");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите число 4");
double k2 = Convert.ToInt32(Console.ReadLine());


double[] Metod(double b1, double k1, double b2, double k2)
{
    double y = 0;
    double x = 0;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * (b2 - b1) / (k1 - k2) + b1;
    double[] arr = new double[2];
    arr[0] = x;
    arr[1] = y;
    return arr;
}
void PrintArray(double[] array)
{
    System.Console.Write("");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");

    }
    System.Console.Write("");
}

double[] metod = Metod(b1, k1, b2, k2);
PrintArray(metod);