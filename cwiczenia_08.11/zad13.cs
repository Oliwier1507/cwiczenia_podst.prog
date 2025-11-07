using System;

internal class Program
{
    // Zadanie 3.13 - wszystkie liczby doskonałe w przedziale <1;10000>
    // Prosty algorytm sumujący dzielniki właściwe.
    private static void Main(string[] args)
    {
        Console.WriteLine("Liczby doskonałe w przedziale 1..10000:");
        for (int x = 2; x <= 10000; x++)
        {
            int sum = 0;
            for (int i = 1; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == x)
            {
                Console.WriteLine(x);
            }
        }
    }
}
