using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = 0;
        double sum = 0.0;

        for (int i = 1; i <= 100; i++)
        {
            sum += System.Math.Pow(-1, n) / (2 * n + 1);
            n++;
        }

        System.Console.WriteLine($"Przybliżenie liczby Pi (100 wyrazów): {4 * sum}");
        System.Console.WriteLine($"Odchyłka od Math.PI: {System.Math.Abs(System.Math.PI - 4 * sum)}");
    }
}