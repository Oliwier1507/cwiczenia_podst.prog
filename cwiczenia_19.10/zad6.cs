using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double result = Math.Pow(((6.2 / 0.31 - 5.0 / 9.0 * 0.9) * 0.2 + 0.15) / 0.02, 3);
        Console.WriteLine(result);
    }
}