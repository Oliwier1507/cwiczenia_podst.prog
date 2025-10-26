using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Podaj swoje imię: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Witaj {name}");
    }
}