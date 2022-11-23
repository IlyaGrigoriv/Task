// Задача 30: Напишите программу. 
// 1 которая выводит массив из 8 элементов,
// 2 заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
void RandowArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=rnd.Next(0,2);
    }
}
RandowArray(array);


void PrintArray(int[] array)
{
    //int count = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]}");

    }
}
PrintArray(array);