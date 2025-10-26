using System;

internal class zad11
{
    private static void Main(string[] args)
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Wybierz operację arytmetyczną: ");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");
        Console.Write("Wybieram: ");

        string input = Console.ReadLine();
        char wybor = string.IsNullOrEmpty(input) ? ' ' : input[0];

        switch (wybor)
        {
            case '1':
                Console.WriteLine($"Wynik: {a} + {b} = {a + b}");
                break;
            case '2':
                Console.WriteLine($"Wynik: {a} - {b} = {a - b}");
                break;
            case '3':
                Console.WriteLine($"Wynik: {a} * {b} = {a * b}");
                break;
            case '4':
                if (b != 0)
                {
                    Console.WriteLine($"Wynik: {a} / {b} = {a / b}");
                }
                else
                {
                    Console.WriteLine("Błąd: Nie można dzielić przez zero.");
                }
                break;
            default:
                Console.WriteLine("Nieprawidłowy wybór operacji.");
                break;
        }
    }
}