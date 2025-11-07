using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Podaj liczbę naturalną: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Dzielniki liczby {n}");
        int i = 1;
        do
        {
            if (n % i == 0)
                Console.WriteLine(i);
            i++;
        } while (i <= n);
    }
}
