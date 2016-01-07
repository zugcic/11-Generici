using System;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    class Program
    {
        // Primjer kako su iste kolekcije s različitim tipovima paramtara potpuno različiti tipovi
        static void Main(string[] args)
        {
            Dictionary<string, int> brojevi = new Dictionary<string, int>();
            brojevi.Add("jedan", 1);
            brojevi.Add("dva", 2);
            brojevi.Add("tri", 3);

            foreach (var e in brojevi)
            {
                Console.WriteLine("\"{0}\" ima vrijednost {1}", e.Key, e.Value);
            }

            Console.WriteLine();

            // Identične kolekcije s istim tipom parametara možemo kombinirati, npr pridruživati:
            Dictionary<string, int> brojevi2 = brojevi;
            brojevi["četiri"] = 4;

            foreach (var e in brojevi2)
            {
                Console.WriteLine("\"{0}\" ima vrijednost {1}", e.Key, e.Value);
            }


            // Međutim, za različite tipove parametara to nije moguće, jer oni daju potpuno različite tipove:
            Dictionary<string, string> numbers = new Dictionary<string, string>();
            numbers.Add("one", "jedan");
            numbers.Add("two", "dva");
            numbers.Add("three", "tri");

            // TODO: Otkomentirati donju naredbu i provjerite pogrešku koju prevoditelj prijavljuje
            //brojevi = numbers;

            Console.WriteLine("Gotovo!!!");
            Console.ReadLine();
        }
    }
}
