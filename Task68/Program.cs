// Задача 68: 
// 1 Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 3;
int n = 5;


int Fibonach(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Fibonach(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Fibonach(m - 1, Fibonach(m, n - 1));
    }
    else
        return n + 1;
}

Console.WriteLine(Fibonach(m,n));
