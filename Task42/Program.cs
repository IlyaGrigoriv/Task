// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



int Num = 344;

int[] sum(int Num)
{
    int size = 1;
    if(Num>0 & Num<10) size= 2;
    if (Num > 9 & Num < 100) size = 6;
    if (Num>99 & Num< 1000) size =9;
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        //size = i;
        arr[i] = Num % 2;
        Num = Num / 2;
    }
    return arr;
}
void PrintArray(int[] array)

{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");

    }
    System.Console.Write("]");
}
int [] TurnArr(int [] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        int temp=0;
        temp =arr[i];
        arr[i]= arr[Length-1];



    }




}

int[] sum1 = sum(Num);

PrintArray(TurnArr(sum1));
