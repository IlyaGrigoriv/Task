// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int rows = 3;
int colums = 4;
int min = -10;
int max = 100;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

double[] AverageSumRowsArr(int[,] matrix)
{
    double[] arr = new double[4];
    int count = rows;
    //int count2 =0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        arr[i] = arr[i];
        for (int j = 0; j < matrix.GetLength(1); count++ ,j++)
        {
            arr[j] += matrix[i, j];
        }
    }
    for (int i = 0; i < arr.Length; i++)
    {
       // System.Console.Write($" {arr[i]} |" );
        arr[i] = arr[i]/rows ;
        arr [i] = Math.Round(arr[i], 2, MidpointRounding.ToZero);
    }

    return arr;
}
void PrintArray(double[] array)
{
    System.Console.Write(" [");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]} ");
    }
    System.Console.Write(" ] ");
}



int[,] array2D = CreateMatrixRndInt(rows, colums, min, max);
PrintMatrix(array2D);
double[] arr = AverageSumRowsArr(array2D);
Console.Write("Среднее арифметическое каждого столбца "); PrintArray(arr);