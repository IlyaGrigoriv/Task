// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int rows = 3;
int colums = 3;
//int min = 1;
//int max = 99;

// int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
// {
//     int[,] matrix = new int[rows, colums];
//    // int temp = 0;
//     // for (int i = 0; i < matrix.GetLength(0); i++)
//     // {
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             matrix[0, j] = 1; //+ j;
//             //temp = matrix[0, j];//4
//         }
//         for (int k = 1; k < matrix.GetLength(1); k++)
//         {
//             matrix[k,colums-1] = 1; //+ k;//5
//             //temp = matrix[k, 3];
//         }
//         // for (int g = 0 ; g< matrix.GetLength(2); g++)
//         // {
//         //     matrix[0, g] = 1 ;//+ g;
//         //     //temp = matrix[g, 3];
//         // }
//         for (int h = 0; h <matrix.GetLength(0); h++)
//         {
//             matrix[h, 0] = 1 ;//+ h;
//             //temp = matrix[h, 3];
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

// int[,] matrix1 = new int[rows, colums];

int[,] SnakeMatrix()
{
    int[,] matrix = new int[rows, colums]; PrintMatrix(matrix);
    int i = 0;
    int j = 0;
    int count = 1;
    for (j = 0; j < matrix.GetLength(1); j++)
        for (i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, j] == 0 & matrix[i, j] < matrix.GetLength(0))
            {
                matrix[i, j] += count; PrintMatrix(matrix); System.Console.WriteLine();
                count++ ;
            }
            if (matrix[i, j] == matrix.GetLength(0) & matrix[i, j] != matrix.GetLength(1))
            {
                j++; i++;
                matrix[i, j] += count; PrintMatrix(matrix); System.Console.WriteLine();
                count++ ;
            }
            if (matrix[i, j] == matrix.GetLength(0) & matrix[i, j] == matrix.GetLength(1))
            {
                i--; j--;
                matrix[i, j] += count; PrintMatrix(matrix); System.Console.WriteLine();
                count++ ;
            }
        }

    return matrix;
}

//int[,] Matrix = CreateMatrixRndInt(rows, colums, min, max);
//PrintMatrix(Matrix1);
int[,] Matrix2 = SnakeMatrix();
Console.WriteLine();
PrintMatrix(Matrix2);