// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



int Num = 2345;

int[] BinarySumArr(int Num)
{
    int size = 1;
    if(Num>0 & Num<10) size= 2;
    if (Num > 9 & Num < 100) size = +4;
    if (Num>99 & Num< 1000) size =9;
    if (Num>999 & Num< 10000) size =12;
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
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
void TurnArr(int [] arr)
{
    for(int i=0;i<arr.Length/2;i++)
    {
        int temp;
        temp =arr[i];
        arr[i]= arr[arr.Length-1-i];
        arr[arr.Length-1-i]=temp;
    }

}

int [] Array = BinarySumArr(Num);
//PrintArray(Array);
TurnArr(Array);
Console.Write($"Число {Num} в двоичной исчисление ");
PrintArray(Array);


