using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Pierwsza liczba: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Druga liczba: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Trzecia liczba: ");
        int c = int.Parse(Console.ReadLine());

        // Zagnieżdżone if z else zgodnie z zadaniem 1.3
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine($"Największa liczba to {a}");
            }
            else
            {
                Console.WriteLine($"Największa liczba to {c}");
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine($"Największa liczba to {b}");
            }
            else
            {
                Console.WriteLine($"Największa liczba to {c}");
            }
        }
    }
}