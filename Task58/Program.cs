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
// int min = 2;
// int max = 4;
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

// int[,] SumTwoMatrix(int[,] matrix, int[,] matrix2)
// {
//     if (matrix.GetLength(0) == matrix2.GetLength(1))
//     {
//         int[,] matrix3 = new int[rows, colums];

//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 for (int k = 0; k < matrix.GetLength(0); k++)
//                 {
//                     matrix3[i, j] += matrix[j, k] * matrix2[k, j];
//                 }
//             }
//         }
//         return matrix3;
//     }
//    return 0; //непонимаю что можно записать кроме массива
// }


// int[,] Matrix = CreateMatrixRndInt(rows, colums, min, max);
PrintMatrix(Matrix);
// int[,] Matrix2 = CreateMatrixRndInt(rows, colums, min, max);
Console.WriteLine();
PrintMatrix(Matrix2);
//int[,] Matrix3 = SumTwoMatrix(Matrix, Matrix2);
int[,] Matrix3 =SumTwoMatrix2( Matrix, Matrix2);
PrintMatrix(Matrix3);

Console.WriteLine();
PrintMatrix(Matrix3);

int[,] SumTwoMatrix2(int [,] matrix, int [,] matrix2)
{
    int [,] matrix3 = new int [matrix.GetLength(0),matrix2.GetLength(1)];

    matrix3[0,0] = (matrix[0,0]*matrix2[0,0])+(Matrix[0,1]*matrix2[1,0]);
    matrix3[1,0] = (matrix[1,0]*matrix2[0,0])+(Matrix[1,1]*matrix2[1,0]);
    matrix3[0,1] = (matrix[0,0]*matrix2[0,1])+(Matrix[0,1]*matrix2[1,1]);
    matrix3[1,1] = (matrix[1,0]*matrix2[0,1])+(Matrix[1,1]*matrix2[1,1]);
return matrix3;

}