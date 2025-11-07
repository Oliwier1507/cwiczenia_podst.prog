using System;

internal class Program
{
    // Zadanie 3.12 - wypisz wszystkie liczby bliźniacze (twin primes) w <1;100>
    // Zastosowano prosty test pierwszości z użyciem break.
    private static void Main(string[] args)
    {
        Console.WriteLine("Liczby bliźniacze w przedziale <1;100>:");
        for (int p = 2; p <= 98; p++)
        {
            bool Pfirst = true;
            for (int d = 2; d * d <= p; d++)
            {
                if (p % d == 0)
                {
                    Pfirst = false;
                    break;
                }
            }

            if (!Pfirst) continue;

            int q = p + 2;
            bool Qfirst = true;
            for (int d = 2; d * d <= q; d++)
            {
                if (q % d == 0)
                {
                    Qfirst = false;
                    break;
                }
            }

            if (Qfirst && q <= 100)
            {
                Console.WriteLine(p + " " + q);
            }
        }
    }
}
