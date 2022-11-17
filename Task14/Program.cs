// 14.  Напишите программу, 
// 1 которая принимает на вход число 
// 2 и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.WriteLine("Ввидите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multipliсity(number) ? "да" : "нет");

bool Multipliсity(int num)
{
    return (num % 7 == 0) && (num % 23 == 0);
}


// if ((num % 7 == 0) & (num % 23 == 0))
// Console.WriteLine( "Да");
// else Console.WriteLine("нет");
