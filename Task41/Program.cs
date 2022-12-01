// Задача 41:
// 1  Пользователь вводит с клавиатуры M чисел. 
// 2 Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел вы ввидете?");
int NumSize = Convert.ToInt32(Console.ReadLine());

int[] array = new int[NumSize];

int[] WriteNumArr(int[] arr, int numSize)
{

    for (int i = 0; i < numSize; i++)
    {
        Console.WriteLine($"Ввидите последовательно все числа {i + 1}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
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

int NumNull(int[] array)
{
    int sum = 0;
    int count = 1;
    for (int i = 0; i < array.Length;count++, i++)
        if (array[i] > 0) sum = +count;
        else count=0;
    return sum;

}

int[] writeNumArr = WriteNumArr(array, NumSize);
PrintArray(writeNumArr);
int numNull = NumNull(array);
Console.WriteLine($" В массиве {numNull} чисел больше 0");

