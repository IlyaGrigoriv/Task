// Задача 33: Задайте массив. Напишите программу, 
// 1 которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
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
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

bool SearchNumber(int[] arr, int num)
{
    //int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num) return true;
          
    }
    return false;

}

Console.WriteLine("Ввидите число");
int number = Convert.ToInt32(Console.ReadLine());
int[] Array = CreateArrayRndInt(5, 0, 4);
PrintArray(Array);
bool searchNumber = SearchNumber(Array, number);
Console.WriteLine((searchNumber) ? "да" : "нет");
