// // Задача 58: 
// 1 Задайте две матрицы. 
// 2 Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

int rows = 2;
int colums = 2;
int min = 2;
int max = 4;
int[,] Matrix = new int[,]
{
    {2,4},
    {3,2},
};
int[,] Matrix2 = new int[,]
{
    {3,4},
    {3,3},
};

// int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
// {
//     int[,] matrix = new int[rows, colums];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

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

int[,] SumTwoMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] matrix3 = new int[rows, colums];

    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 1; k < matrix.GetLength(2)-1; k++)
            {
                matrix3[i, j] += matrix[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}


// int[,] Matrix = CreateMatrixRndInt(rows, colums, min, max);
PrintMatrix(Matrix);
// int[,] Matrix2 = CreateMatrixRndInt(rows, colums, min, max);
Console.WriteLine();
PrintMatrix(Matrix2);
int[,] Matrix3 = SumTwoMatrix(Matrix, Matrix2);
Console.WriteLine();
PrintMatrix(Matrix3);