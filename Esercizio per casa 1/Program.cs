using System;

namespace Esercizio_per_casa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero!");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"il numero {n} è PARI");
                    for (int i = 0; i <= n; i++)
                    {
                        Console.WriteLine(i.ToString());
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"il numero {n} è DISPARI");
                }
            }
            else 
            {
                Console.WriteLine("il numero inserito è minore di 0");
            }
            Console.ReadLine();
        }
    }
}
