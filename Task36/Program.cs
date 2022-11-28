// Задача 36: 
// 1 Задайте одномерный массив, 
// 2 заполненный случайными числами. 
// 3 Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    System.Console.Write(" [");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]} ");
    }
    System.Console.Write(" ] ");
}

int SumOddPosition(int[] arr)
{
    int count =0;
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((count % 2) != 0)  sum =arr[i]+sum ;
        count++;
    }
    return sum;

}

int[] Array = NewArray(50, 1, 100);
PrintArray(Array);
SumOddPosition(Array);
System.Console.WriteLine(SumOddPosition(Array));

