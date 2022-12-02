// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
int size = 10;
int min = 0;
int max = 10;
int[] NewArray(int Size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(min, max + 1);
    return arr;

}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");

    }
    System.Console.Write("]");
}

int[] CopyArray(int[] arr)
{
    int[] arr1 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr1[i] = arr[i];
    }
    return arr1;

}

int[] Array = NewArray(size, min, max);
PrintArray(Array);
int[] Array1 = CopyArray(Array);
System.Console.WriteLine();
Array1[0] = 2022;
PrintArray(Array1);