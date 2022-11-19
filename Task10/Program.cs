// Задача 10: Напишите программу,  
// 1 которая принимает на вход трёхзначное число 
// 2 и на выходе показывает вторую цифру этого числа.
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Ввидите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99 || number > 999)
{
    System.Console.WriteLine("Виденно не трехзначное число");
}
else 
{
    int Metoth1(int Numb)
    {
        int Num = Numb / 10;
        int Num2 = Num % 10;
        return Num2;
    }
    int metoth = Metoth1(number);
     Console.WriteLine(metoth);
    
}


// int Number = new Random(). Next(100, 1000);
// Console.WriteLine(Number);
// int Num = Number / 10;
// int Num2 = Num % 10;
// // Console.WriteLine( Num);
// Console.WriteLine(Num2);
