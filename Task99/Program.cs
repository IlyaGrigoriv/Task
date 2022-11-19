
int numA1 = 14212;

int exam1 = numA1 / 10000; System.Console.WriteLine($"exam1 {exam1}");
int exam2 = numA1 % 10; System.Console.WriteLine($"exam2 {exam2}");
if (exam1 != exam2) System.Console.WriteLine("Число не палиндромна");
else
{

    int exam3 = numA1 / 1000; System.Console.WriteLine($"exam3 {exam3}");
    int exam5 = exam3 % 10; System.Console.WriteLine($"exam5 {exam5}");
    int exam4 = numA1 % 100; System.Console.WriteLine($"exam4 {exam4}");
    int exam6 = exam4 /10; System.Console.WriteLine($"exam6 {exam6}");

    if (exam5 == exam6) System.Console.WriteLine("Число полиндромно");
    else
    {
        if (exam5 != exam6) ;
        System.Console.WriteLine("Число не палиндромна");
    }
}

// void Palind(int numA)
// {
//     int num1 = numA / 10000;
//     int num2 = numA / 1000;
//     int num99=num2%10 ;
//     int numTu = num2 % 10;
//     int num01 = numA % 100;
//     int num02 = numA % 10;

//     Console.WriteLine($" разделили на 10000: {num1}");
//     Console.WriteLine($" разделили на 1000: {num2}");
//     Console.WriteLine($" разделили на 1000: {num99}");
//     Console.WriteLine($" процент 10: {numTu}");
//     Console.WriteLine($" процент от 100: {num01}");
//     Console.WriteLine($" процент от 10: {num02}");
// }
//  Palind(numA1);
