// Задача 25: Напишите цикл, 
// 1 который принимает на вход два числа (A и B) 
// 2 и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
System.Console.WriteLine("Ввидите число А");
int A = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Ввидите число B");
int B = Convert.ToInt32(System.Console.ReadLine());
if (B < 0) B = -B;
void ExpNumber(double numA, double numB)
{

    double result = 1;
    for (int i = 0; i < B; i++)
    {
        result = result * numA;

    }
    System.Console.WriteLine($"{A}, {B}-->{result}");

}
ExpNumber(A, B);




// void ExpNumber(double numA, double numB)
// {
//     double result = Math.Pow(numA, numB);
//     System.Console.WriteLine(result);

// }

// ExpNumber(A,B);