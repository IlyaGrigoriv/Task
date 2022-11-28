// Задача 38: 
// 1 Задайте массив вещественных чисел. 
// 2 Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] NewArray(int n, int min, int max)
{
    double[] array = new double[n];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(array[i], 2, MidpointRounding.ToZero);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");

    }
    System.Console.Write("]");
}
double DifferenceMaxMinArray(double[] arr)
{
    double max = 0;
    double min = 1000000;
    double dif = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    dif = max - min;
    dif = Math.Round(dif, 2, MidpointRounding.ToZero);

    return dif; 
}



double[] array = NewArray(5, 1, 10);
PrintArray(array);
System.Console.WriteLine($"-> {DifferenceMaxMinArray(array)}");