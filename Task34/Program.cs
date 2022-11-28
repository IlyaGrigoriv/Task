// Задача 34: 
// // 1 Задайте массив заполненный случайными положительными трёхзначными числами. 
// // 2 Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2

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
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");

    }
    System.Console.Write("]");

}
int SumEvenNumber(int[] array1)
{
    int count=0;
    for (int i = 0; i < array1.Length; i++)
    {
        if ((array1[i]%2)==0) count++; 
    }
    return count;
}

int[] array = NewArray(5, 99, 1000);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Четных чисел в массиве = {SumEvenNumber(array)}");
