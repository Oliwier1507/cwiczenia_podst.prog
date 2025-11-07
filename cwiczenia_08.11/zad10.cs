using System;

internal class Program
{
    // Zadanie 3.10 - rysunek: X z małym kwadratem w środku
    // Prosty, "amatorski" kod z pętlami i konsolowym wypisywaniem.
    private static void Main(string[] args)
    {
        int n = 11; // rozmiar (nieparzysty). Możesz zmienić, np. 9, 11, 13...
        int center = n / 2;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // gwiazdka na przekątnych X lub w małym kwadracie 3x3 w środku
                if (j == i || j == (n - 1 - i) || (Math.Abs(i - center) <= 1 && Math.Abs(j - center) <= 1))
                {
                    Console.Write(" *"); // przed gwiazdką spacja
                }
                else
                {
                    Console.Write("  "); // puste pole (dwie spacje)
                }
            }
            Console.WriteLine();
        }
    }
}
