using System;
internal class Program
{
    private static void Main(string[] args)
    {
        double suma = 0;
        int i = 1;
        double n;

        Console.Write("Podaj liczbę n: ");
        n = double.Parse(Console.ReadLine());

        if (n >= 1)
        {
            while (i <= n)
            {

                suma += i;
                i++;

            }
            Console.WriteLine($"Suma liczb wynosi: {suma}");
        }
        else
        {
            Console.WriteLine("Liczba n musi być większa lub równa 1.");
        }
    }
}