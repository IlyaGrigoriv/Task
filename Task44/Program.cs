// Задача 44: Не используя рекурсию,
// 1 выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Ввидите число ");
int N = Convert.ToInt32(Console.ReadLine());

int[] FibonacciNum(int num)
{
    int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }
    return arr;
}
void PrintArray(int[] array)
{
    System.Console.Write("");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");

    }
    System.Console.Write("");
}
int[] Array = FibonacciNum(N);
System.Console.Write($"{N}--> ");
PrintArray(Array);