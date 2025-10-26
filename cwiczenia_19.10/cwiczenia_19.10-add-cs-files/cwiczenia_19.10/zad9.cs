using System;

internal class zad9
{
    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int middle;

        if (a != b && a != c && b != c)
        {
            if ((a > b && a < c) || (a > c && a < b))
            {
                middle = a;
            }
            else if ((b > a && b < c) || (b > c && b < a))
            {
                middle = b;
            }
            else
            {
                middle = c;
            }

            Console.WriteLine($"Środkowa liczba to: {middle}");
        }
        else
        {
            Console.WriteLine("Liczby nie są różne");
        }
    }
}