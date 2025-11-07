using System;
internal class Program
{
    private static void Main(string[] args)
    {

          Console.WriteLine("Wpisuj kolejne liczby: ");


        double suma = 0;
        int licznik = 0;

        

        while (suma<=100)
        {
            double x = double.Parse(Console.ReadLine());
          
            
            suma += x;
            licznik++;
           

            if (suma > 100)
            {
                Console.WriteLine($"Suma wynosi: {suma}");
                Console.WriteLine($"Liczb dodanych: {licznik}");
            }
           
        }

    }
}