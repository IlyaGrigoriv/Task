// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



int Num = 10;
int[] arr = { 0, 0, 0, 0 };
int[] sum(int[] arr, int Num)
{
    for (int i = 0; Num == 0; i++)
    {
        if ((Num / 2) % 10 == 0) arr[i] = 0;
        else arr[i] = 1;
        Num = (Num / 2) % 10;
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

int[] sum1 = sum(arr, Num);
PrintArray(sum1);
