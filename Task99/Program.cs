// // Задача 58: 
// 1 Задайте две матрицы. 
// 2 Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// int rows = 2;
// int colums = 2;
// int min = 2;
// int max = 4;
int[,] Matrix = new int[,]
{   {1,2,3},                   // 1 2 3
    {2,3,2},};                 // 2 3 2
int[,] Matrix2 = new int[,]
{   {3,4},                     // 3 4
    {3,3},                     // 3 3
    {1,2},};                   // 1 2
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2}, ");
//             else Console.Write($"{matrix[i, j],2} ");
//         }
//         Console.WriteLine("|");
//     }
// }
// int[,] matrixItog = new int[rows, colums];
// int[] matrix4 = new int[colums];

// for (int i = 0; i < Matrix.GetLength(0); i++)
// {
    int temp = 0;
    int temp2 = 0;
    for (int j = 0; j < Matrix.GetLength(0); j++)
    {
        
            temp+= Matrix[0, j] * Matrix2[j, 0]; System.Console.WriteLine($"1   --{temp}");
            
        
    }
    for (int k = 0; k < Matrix.GetLength(1); k++)
    {
        temp2+= Matrix[0, k] * Matrix2[0,k ];System.Console.WriteLine($"2   --{temp2}");
    }

// }













// PrintMatrix(Matrix);
// Console.WriteLine();
// PrintMatrix(Matrix2);
