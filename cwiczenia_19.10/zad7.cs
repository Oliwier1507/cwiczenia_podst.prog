using System;

internal class zad7
{
    static void Main(string[] args)
    {
        double a = Math.Pow(Math.Sqrt(2), Math.Sqrt(3));
        double b = Math.Pow(Math.Sqrt(3), Math.Sqrt(2));

        Console.WriteLine(a);
        Console.WriteLine(b);

        if (a > b)
        {
            Console.WriteLine($"Liczba {a} jest większa");
        }
        else if (b > a)
        {
            Console.WriteLine($"Liczba {b} jest większa");
        }
        else
        {
            Console.WriteLine("Obie liczby są równe");
        }
    }
}