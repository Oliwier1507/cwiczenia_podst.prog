using System;

class Program
{
    static void Main()
    {
        int n = 11;
        int center = n / 2;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == i || j == (n - 1 - i) || (Math.Abs(i - center) <= 1 && Math.Abs(j - center) <= 1))
                {
                    Console.Write(" *");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}