using System;
using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        double Kn=0;
        double K = 10000;
        int n = 1;
        double p = 5.0 / 100;
        int k = 12;

        for (int i = 1; i <= 12; i++)
        {
            Kn = K * Math.Pow(1 + p / k,i);
        }   


        Console.Write($"Odsetki od lokaty wynoszą: {Math.Round(Kn-K)} zł");
    }
}