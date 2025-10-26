using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Wprowadź pierwszą liczbę: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Wprowadź drugą liczbę: ");
        float b = float.Parse(Console.ReadLine());

        Console.WriteLine($"Średnia arytmetyczna liczb {a} i {b} wynosi {(a + b) / 2.0}");
    }
}