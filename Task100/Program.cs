
const int val = 6;
const int column = 5;

int[,] mass = new int[val, column];
int[] mass1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int counter = 1;

for (int i = 0; i < val; i++)
{
    if (i % 2 == 0)
    {
        for (int j = 0; j < column; j++)
        {
            mass[i, j] = counter;
            counter++;
            Console.Write("{0}\t", mass[i, j]);
        }
    }
    else
    {
        for (int j = column - 1; j >= 0; j--)
        {
            mass[i, j] = counter;
            counter++;
            Console.Write("{0}\t", mass[i, j]);
        }
    }

    Console.WriteLine();
}