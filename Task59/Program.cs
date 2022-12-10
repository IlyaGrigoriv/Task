// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int rows = 10;
int colums = 10;
int min = 1;
int max = 99;

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

int[] SeorchMinNumMatrix(int[,] matrix)
{
    int[] arr = new int[2];
    int min = matrix[0, 0]; System.Console.WriteLine(min);
    arr[0] = matrix.GetLength(0);
    arr[1] = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if (matrix[i, j] < min )//| matrix[i, j] == 0)
            {
                min = matrix[i, j];
                arr[0] = i;
                arr[1] = j;
            }
        }

    }
    Console.WriteLine(min);
    return arr; //Console.WriteLine(min);

}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
int[,] MinusRowsComsMatrix(int[,] matrix, int[] arr)
{
    int rows = arr[0];
    int colums = arr[1];
    int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //if (arr [i,j] == matrix [i,j])
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != rows || j != colums)
                matrix2[i, j] = matrix[i, j];

        }

    }
    return matrix2;
}




int[,] Matrix = CreateMatrixRndInt(rows, colums, min, max);
PrintMatrix(Matrix);
int[] ArrayIndex = SeorchMinNumMatrix(Matrix);
System.Console.WriteLine();
PrintArray(ArrayIndex);
int[,] Matrix2 = MinusRowsComsMatrix(Matrix, ArrayIndex);
// PrintMatrix2(Matrix,ArrayIndex);
PrintMatrix(Matrix2);
