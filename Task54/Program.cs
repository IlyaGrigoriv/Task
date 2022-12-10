// Задача 54: 
// 1 Задайте двумерный массив. 
// 2 Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int rows = 4;
int colums = 6;
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

int[,] OrderMatrix(int[,] matrix)
{
    int max = 1;
    for (int y = 0; y < matrix.GetLength(0); y++)
    {

        for (int x = 1; x < matrix.GetLength(1) ; x++)
        {
            if (matrix[y, x] > matrix[y, x - 1])
            {
                max = matrix[y, x-1];
                matrix[y, x-1] = matrix[y, x ];
                matrix[y, x ] = max;
                x=0;
            }
        }

    }
return matrix;
}

int[,] Matrix = CreateMatrixRndInt(rows, colums, min, max);
PrintMatrix(Matrix);
int[,] Matrix2 = OrderMatrix(Matrix);
System.Console.WriteLine();
PrintMatrix(Matrix2);