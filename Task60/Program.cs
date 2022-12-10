// 1 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// 2 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
int z = 3;
int x = 3;
int y = 3;
int min = 10;
int max = 50;

int[,,] CreateMatrixRndInt(int z, int x, int y, int min, int max)
{
    int[,,] matrix = new int[z, x, y];
    Random rnd = new Random();
    int s=1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {    s+=i;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {    s+=i+j;
            for (int k = 0; k < matrix.GetLength(2); k++)
            {  
                matrix[i, j, k] +=s+i+j+k;
                s=matrix[i, j, k];
            }  
        }

    }
    return matrix;
}

void Printmatrix3d(int[,,] matrix3d)
{
    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        Console.WriteLine($"Страница   {i+1}");
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3d.GetLength(2); k++)
            {
                Console.Write($"{matrix3d[i, j, k]}--({i},{j},{k}), ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("|");
    }
}



int[,,] Matrix3d = CreateMatrixRndInt(z, x, y, min, max);
Printmatrix3d(Matrix3d);
