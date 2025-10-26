using System;

internal class zad12
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę z przedziału 1-999");
        int liczba = int.Parse(Console.ReadLine());

        if (liczba < 1 || liczba > 999)
        {
            Console.WriteLine("Liczba jest spoza przedziału");
        }
        else
        {
            if (liczba >= 100)
            {
                int jednosci = liczba % 10;
                int dziesiatki = (liczba / 10) % 10;
                int setki = liczba / 100;

                int suma = jednosci + dziesiatki + setki;

                if (suma % 3 == 0)
                {
                    Console.WriteLine("Liczba jest podzielna przez 3");
                }
                else
                {
                    Console.WriteLine("Liczba nie jest podzielna przez 3");
                }
            }
            else if (liczba >= 10)
            {
                int jednosci = liczba % 10;
                int dziesiatki = (liczba / 10) % 10;
                int suma = jednosci + dziesiatki;
                if (suma % 3 == 0)
                {
                    Console.WriteLine("Liczba jest podzielna przez 3");
                }
                else
                {
                    Console.WriteLine("Liczba nie jest podzielna przez 3");
                }
            }
            else
            {
                if (liczba % 3 == 0)
                {
                    Console.WriteLine("Liczba jest podzielna przez 3");
                }
                else
                {
                    Console.WriteLine("Liczba nie jest podzielna przez 3");
                }
            }
        }
    }
}