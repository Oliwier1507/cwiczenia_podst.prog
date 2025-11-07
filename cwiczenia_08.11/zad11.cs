using System;

class Program
{
    static void Main()
    {
        Console.Write("Wprowadź liczbę wierszy (od 9 do 15 nieparzysta): ");
        string input = Console.ReadLine();
        int n;
        if (!int.TryParse(input, out n))
        {
            Console.WriteLine("Błąd! Podaj liczbę całkowitą.");
            return;
        }
        if (n < 9 || n > 15 || n % 2 == 0)
        {
            Console.WriteLine("Błąd! Liczba musi być nieparzysta i w przedziale 9..15.");
            return;
        }

        int srodek = n / 2;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || i == n - 1 || j == 0 || j == n - 1 || i == srodek || j == srodek)
                {
                    Console.Write(" *");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}