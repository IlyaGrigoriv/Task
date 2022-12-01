// Задача 39: Напишите программу, 
// 1 которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int [] Array = {1,2,3,4,5};


void PrintArray(int[] array)
{
    System.Console.Write(" [");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]} ");
    }
    System.Console.Write(" ] ");
}

void  ReverseArray (int [] arr)
{       int temp;
        for (int i=0; i< arr.Length/2;i++)
        {
         temp = arr[i];
        arr[i] = arr[arr.Length -1 -i];
        arr[arr.Length -1 -i]= temp;
        }
}
PrintArray(Array);
ReverseArray(Array);
Console.WriteLine();
PrintArray(Array);