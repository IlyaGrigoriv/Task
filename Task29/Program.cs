// Задача 29: Напишите программу, 
// 1 которая задаёт массив из 8 элементов 
// 2 и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] arr = { 1, 2, 5, 7, 19, 6, 1, 33 };
void PrintArr(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}  ");// почему выводим i 
    }
}
PrintArr(arr);