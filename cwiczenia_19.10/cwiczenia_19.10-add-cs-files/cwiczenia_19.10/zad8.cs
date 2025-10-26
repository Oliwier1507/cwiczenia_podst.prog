using System;

internal class zad8
{
    private static void Main(string[] args)
    {
        int rok;

        Console.Write("Podaj rok: ");
        rok = int.Parse(Console.ReadLine());

        if (rok % 4 == 0 && (rok % 100 != 0 || rok % 400 == 0))
        {
            Console.WriteLine($"Rok {rok} jest przestępny.");
        }
        else
        {
            Console.WriteLine($"Rok {rok} nie jest przestępny.");
        }
    }
}