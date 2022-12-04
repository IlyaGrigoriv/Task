//  Напишите программу,
//  1  которая на вход принимает позиции элемента в двумерном массиве,
//  2 и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
bool SearchNumberMatrix(int[,] matrix, int X, int Y, int rows, int colums)
{
    if (X<0 || Y<0) return false;
     if (X <= rows & Y <= colums) return true;
         else return false;
    //if (matrix[X, Y] <= rows & matrix[X, Y] < colums) return true;    не работает
    //else return false;
}


//  void  PrintNumberMatrix(int [,] matrix, int X,int Y)
//  {
//     System.Console.WriteLine(matrix[X, Y] );
//  }

Console.WriteLine("Ввидите первую кардинату массива ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите вторую кардинату массива ");
int Y = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(rows, colums, min, max);
PrintMatrix(array2D);
bool A = SearchNumberMatrix(array2D, X, Y, rows, colums);
Console.WriteLine(SearchNumberMatrix(array2D, X, Y, rows, colums) ? $"{array2D [X,Y]}" : "Такого числа нет в массиве");
// Console.Write("Это число ");
// PrintNumberMatrix(array2D,X,Y);