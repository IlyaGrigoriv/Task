// Задача 56: 
// 1 Задайте прямоугольный двумерный массив. 
// 2 Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
//  1 строка

int rows = 3;
int colums = 3;
int min = 1;
int max = 10;

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2}, ");
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");

    }
    System.Console.Write("]");
}

int[] SumRowsMatrix(int[,] matrix)
{
    int[] arr = new int[colums];
    int k = 0;
    int sum = 0;
    for (int y = 0; y < matrix.GetLength(1); y++)
    {

        for (int x = 0; x < matrix.GetLength(1); x++)
        {
            sum += matrix[y, x];

        }
        arr[k] = sum;
        k++;
        sum = 0;
    }
    return arr;
}

void MinRowsMatrix(int[] arr)
{
    int min = 9999;
    int index=0;
    for (int x = 0; x < colums; x++)
    {   
        if (arr[x] < min)
        {
            index = x+1;
            min = arr[x];
        }
      
    }
  System.Console.Write($"{index} строка");
}
int[,] Matrix = CreateMatrixRndInt(rows, colums, min, max);
PrintMatrix(Matrix);
int[] Array = SumRowsMatrix(Matrix);
PrintArray(Array);
Console.WriteLine();
MinRowsMatrix(Array);
