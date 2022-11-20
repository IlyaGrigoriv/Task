// Напишите программу, 
// 1 которая принимает на вход число (N) 
// 2 и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125



	System.Console.WriteLine("Ввидите число:");
	int number = Convert.ToInt32(Console.ReadLine());
	
	void Cubed  (int n )
	 {
	for (int i = 1; i <= n; i++) 
	{
	    int resolt = i * i * i;
	    System.Console.WriteLine($"{i} | {resolt}") ;
	
    }
     }
    Cubed(number);
