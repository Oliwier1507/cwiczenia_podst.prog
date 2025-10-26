using System;

internal class zad5
{
    private static void Main(string[] args)
    {
        Console.Write("Podaj współczynnik a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj współczynnik b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Podaj współczynnik c: ");
        double c = double.Parse(Console.ReadLine());

        if (a != 0)
        {
            double delta = (Math.Pow(b, 2) - 4 * a * c);
            if (delta < 0)
            {
                Console.WriteLine("Brak rozwiązań rzeczywistych");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"Jest jedno rozwiązanie rzeczywiste: x = {-b / (2 * a)}");
            }
            else // delta > 0
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Są dwa rozwiązania rzeczywiste: x1 = {x1}, x2 = {x2}");
            }
        }
        else // a == 0 => równanie liniowe lub brak/inf rozwiązania
        {
            if (b != 0)
            {
                double x = -c / b;
                Console.WriteLine($"Równanie liniowe. Rozwiązanie: x = {x}");
            }
            else
            {
                if (c == 0)
                    Console.WriteLine("Nieskończenie wiele rozwiązań (0 = 0).");
                else
                    Console.WriteLine("Brak rozwiązań (sprzeczne równanie).");
            }
        }
    }
}