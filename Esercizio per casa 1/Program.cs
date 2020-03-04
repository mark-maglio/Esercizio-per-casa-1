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
                    for (int i = 1; i <= n; i++)
                    {
                        if( i % 2 == 0)
                        {
                            Console.WriteLine(i.ToString());
                        }
                    }
                }
                else
                {
                    for (int c = 1 ; c <= n; c++)
                    {
                        
                    }
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
