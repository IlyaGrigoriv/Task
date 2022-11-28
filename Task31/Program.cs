// Задача 31: 
// 1 Задайте массив из 12 элементов, 
// 2 заполненный случайными числами из промежутка [-9, 9].
// 3 Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] NewArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},  ");
        else Console.WriteLine($"{arr[i]} ]");
    }


}

int SumNegativeNumber(int[] arr)
{
    int sumnegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumnegative += arr[i];
    }
    return sumnegative;
}
int SumPositiveNumber(int[] arr)
{
    int sumpositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumpositive += arr[i];
    }
    return sumpositive;
}


int[] newArray = NewArray(12, -9, 9);
PrintArray(newArray);
int sumNegativeNumber = SumNegativeNumber(newArray);
int sumPositiveNumber = SumPositiveNumber(newArray);
Console.WriteLine($"Сумма положительных чисел {sumNegativeNumber}");
Console.WriteLine($"Сумма положительных чисел {sumPositiveNumber}");

