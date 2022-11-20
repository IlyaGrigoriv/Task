// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc)
{
    string x,y;
    if (xc == 1) return "x > 0 && y > 0";
    if (xc == 2) return x > 0 && y < 0;
    if (xc == 3) return x < 0 && y < 0;
    if (xc == 4) return x < 0 && y > 0;
    return 0;
}

int quarter1 = Quarter(quarter);
int result = quarter1 > 0
        ? $"Указанные координаты соответствуют четверти -> {quarter}"
        : "Введены некорректные координаты";
Console.WriteLine(result);
