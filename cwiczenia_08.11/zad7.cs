using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double x;

        do
        {
            Console.WriteLine($"Podaj liczbę: ");
            x = double.Parse(Console.ReadLine());
        }
        while(!(Math.Abs(x) > 2 && Math.Abs(x) < 3));
    }
}