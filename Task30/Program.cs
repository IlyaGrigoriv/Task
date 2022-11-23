// Задача 30: Напишите программу. 
// 1 которая выводит массив из 8 элементов,
// 2 заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] array = { 1, 0, 1, 1, 0, 1, 0, 0 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($" {array[i]}");

    }
}
PrintArray(array);