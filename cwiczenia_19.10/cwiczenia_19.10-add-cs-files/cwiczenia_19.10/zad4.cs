using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj pierwszą liczbę: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Podaj trzecią liczbę: ");
        float c = float.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine($"Największa liczba to: {a}");
        }
        else if (b > c)
        {
            Console.WriteLine($"Największa liczba to: {b}");
        }
        else
        {
            Console.WriteLine($"Największa liczba to: {c}");
        }
    }
}