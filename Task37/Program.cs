// Задача 37: 
//  1 Найдите произведение пар чисел в одномерном массиве.
// 2 Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size)
{
    int[] arr = new int[size];


    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1; System.Console.WriteLine($"выводит каждое число {arr[i]}");
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

int [] SumCalcul(int [] arra)
{
    int[] arr2 = new int[5];
        for (int i = 0; i < arra.Length; i++)
    {
        arr2 [i]= arr2[i]+ arra[5]-1;
    }
    return arr2;
}

Console.WriteLine("Видите длинну массива");
int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Видите минимальное значение массива");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Видите максимальное значение массива");
// int C = Convert.ToInt32(Console.ReadLine());
int[] Array = CreateArrayRndInt(A);
int [] Array2 = SumCalcul(Array);
PrintArray(Array);
