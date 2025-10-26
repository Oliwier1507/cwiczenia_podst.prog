using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        // Pełne posortowanie dla 3 liczb przy użyciu 3 porównań/swapów
        if (a > b) { int temp = a; a = b; b = temp; }
        if (a > c) { int temp = a; a = c; c = temp; }
        if (b > c) { int temp = b; b = c; c = temp; }

        Console.WriteLine(a + " " + b + " " + c + " ");
    }
}