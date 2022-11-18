// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
sting quarter = Convert.ToInt32(Console.ReadLine());

string Quarter(string xc )
{
    if (xc == 1) return "x > 0 && y > 0";
    if (xc == 2) return "x > 0 && y < 0
    if (xc == 3) return "x < 0 && y < 0";
    if (xc == 4) return "x < 0 && y > 0";
    return 0;
}

int quarter = Quarter(quarter);
string result = quarter > 0
        ? $"Указанные координаты соответствуют четверти -> {quarter}"
        : "Введены некорректные координаты";
Console.WriteLine(result);
