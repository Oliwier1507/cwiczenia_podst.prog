using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double x;
        int i = 1;
        double suma = 0;

        Console.Write("Podaj liczbę: ");
        x = double.Parse(Console.ReadLine());

        if (x >= 1)
        {
            while (suma < x)
            {
                suma += i;
                i++;
            }
            
            Console.WriteLine($"Należy dodać {i - 1} liczby, aby suma osiągnęła lub przekroczyła zadaną wartość.");
        }
        else
        {
            Console.WriteLine("Wartość powinna być większa lub równa 1.");
        }
    }
}