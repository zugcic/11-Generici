using System;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    public class GeneričkeKolekcijeSRazličitimParametrima
    {
        public static void PridruživanjeDvijuKolekcijaSIstimParametrima()
        {
            Dictionary<string, int> brojevi = new Dictionary<string, int>();
            brojevi.Add("jedan", 1);
            brojevi.Add("dva", 2);
            brojevi.Add("tri", 3);

            foreach (var e in brojevi)
            {
                Console.WriteLine("\"{0}\" = {1}", e.Key, e.Value);
            }

            Console.WriteLine();

            // TODO: Deklarirati novi rječnik tipa Dictionary<string, int>, pridružiti mu sadržaj rječnika 'brojevi' te ponoviti ispis svih članova novog rječnika. Prevesti program, pokrenuti ga i provjeriti ispis.

        }

        public static void PridruživanjeDvijuKolekcijaSRazličitimParametrima()
        {
            Dictionary<string, string> numbers = new Dictionary<string, string>();
            numbers.Add("one", "jedan");
            numbers.Add("two", "dva");
            numbers.Add("three", "tri");

            // TODO: Otkomentirati donju naredbu i provjerite pogrešku koju prevoditelj prijavljuje.
            //brojevi = numbers;

            foreach (var e in numbers)
            {
                Console.WriteLine("\"{0}\" = {1}", e.Key, e.Value);
            }
        }


        static void Main(string[] args)
        {
            PridruživanjeDvijuKolekcijaSIstimParametrima();

            PridruživanjeDvijuKolekcijaSRazličitimParametrima();

            Console.WriteLine("Gotovo!!!");
            Console.ReadKey();
        }
    }
}
