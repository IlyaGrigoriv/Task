// 11. 
// 1 Напишите программу, которая выводит случайное трёхзначное число
// 2 и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int RemoveSecondDigit(int num)
{

    int a = num / 100;
    int b = num % 10;
    int result = a * 10 + b;
        return result;
}
Console.WriteLine(RemoveSecondDigit(number));