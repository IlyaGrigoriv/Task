
int numA1 = 12322;

int exam1 = numA1 / 10000;
int exam2 = numA1 % 10;
if (exam1 != exam2) System.Console.WriteLine("не палиндромна");


void Palind(int numA)
{
    int num1 = numA / 10000;
    int num2 = numA / 1000;
    int numTu = num2 % 10;
    int num01 = numA % 100;
    int num02 = numA % 10;

    Console.WriteLine($" разделили на 10000: {num1}");
    Console.WriteLine($" разделили на 1000: {num2}");
    Console.WriteLine($" процент 10: {numTu}");
    Console.WriteLine($" процент от 100: {num01}");
    Console.WriteLine($" процент от 10: {num02}");
}
int palind = Palind(numA1);