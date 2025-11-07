using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;
        int a;
        int b;
        int wynik = 1;

        Console.WriteLine("Podaj liczbe: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj potege: ");
        b = int.Parse(Console.ReadLine());

        if (a > 0 && b > 0)
        {
            while (i < b)
            {
                wynik *= a;
                i++;
            }
            System.Console.WriteLine($"{a} do potegi {b} = {wynik}");

        }
        else
        {
            System.Console.WriteLine("Podaj liczby calkowite dodatnie");

        }
    }
}