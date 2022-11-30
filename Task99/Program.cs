

int Num = 10;
int[] arr = { 0, 0, 0, 0 };
int[] sum(int[] arr, int Num)
{
    for (int i = 0; Num == 0; i++)
    {
        if ((Num / 2) % 10 == 0) arr[i] = 0;
        else arr[i] = 1;
        Num = (Num / 2) % 10;
    }
    return arr;
}
int[] sum1 = sum(arr, Num);
System.Console.WriteLine(sum(arr, Num));
System.Console.WriteLine(sum1);