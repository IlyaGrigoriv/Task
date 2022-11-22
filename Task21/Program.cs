// Задача 21
// Напишите программу, которая 
// 1 принимает на вход координаты двух точек 
// 2 и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите точки А по оси Х: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точки А по оси Y: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точки А по оси Z: ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точки B по оси Х: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точки B по оси Y: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точки B по оси Z: ");
int Bz = Convert.ToInt32(Console.ReadLine());


// double Distance(int Ax, int Ay, int Az, int Bx, int By, int Bz)
// {
//    double SquareX = (Ax - Bx) * (Ax - Bx);//   System.Console.WriteLine(SquareX);// квадрат
//    double SquareY = (Ay - By) * (Ay - By);// System.Console.WriteLine(yc);
//    double SquareZ = (Az - Bz) * (Az - Bz); //ystem.Console.WriteLine(zc);
//    double result = Math.Sqrt(SquareX + SquareY + SquareZ);//System.Console.WriteLine(result);//из корня
//    return result;
// }

double res = Distance(Ax, Ay, Az, Bx, By, Bz);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);

double Distance(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    double result =Math.Pow( (Ax - Bx),2)  
    + Math.Pow((Ay - By),2)  
    + Math.Pow((Az - Bz),2) ; //;System.Console.WriteLine(result);
    // double SquareX = (Ax - Bx) * (Ax - Bx);//   System.Console.WriteLine(SquareX);// квадрат
    // double SquareY = (Ay - By) * (Ay - By);// System.Console.WriteLine(yc);
    // double SquareZ = (Az - Bz) * (Az - Bz); //ystem.Console.WriteLine(zc);
     double result2 = Math.Sqrt(result);//System.Console.WriteLine(result);//из корня
    return result2;
}