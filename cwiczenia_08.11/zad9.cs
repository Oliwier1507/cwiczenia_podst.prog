using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int target = 10;
        int ways = 0;

        Console.WriteLine($"Wszystkie kombinacje monet 1zł, 2zł i 5zł dające {target} zł:");

        for (int c = 0; c <= target / 5; c++)
        {
            for (int b = 0; b <= (target - 5 * c) / 2; b++)
            {
                int a = target - 5 * c - 2 * b;
                if (a >= 0)
                {
                    ways++;
                    Console.WriteLine($"{ways}. {a} x 1zł, {b} x 2zł, {c} x 5zł");
                }
            }
        }

        Console.WriteLine($"Łącznie kombinacji: {ways}");
    }
}