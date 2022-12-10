// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int rows = 3;
int colums = 3;
int min = 1;
int max = 5;

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
int[] CountMatrix(int[,] matrix)
{
    int[] arr = new int[rows * colums];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            arr[k++] = matrix[i, j];
            //arr[i] = matrix[j, i];
        }
    }

    return arr;
}

void PrintCountSumNumbArray(int[] arr)
{
    int count = 1;
    int sum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == sum) count++;
        else {Console.WriteLine($"{sum} используется {count} раз");
        count = 1;
        sum = arr[i];
        }
    }
Console.WriteLine($"{sum} используется {count} раз");

}

int[,] Matrix = CreateMatrixRndInt(rows, colums, min, max);
PrintMatrix(Matrix);
int[] Array1 = CountMatrix(Matrix);
Console.WriteLine();
PrintArray(Array1);
Array.Sort(Array1);
Console.WriteLine();
PrintArray(Array1);
PrintCountSumNumbArray(Array1);


