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
			

			// deklarirati novi rječnik tipa dictionary<string, int>, 
			//pridružiti mu sadržaj rječnika 'brojevi' te ponoviti ispis svih članova novog rječnika. 
			//prevesti program, pokrenuti ga i provjeriti ispis.
			Dictionary<string, int> brojevi1 = new Dictionary<string, int>();
			
			brojevi1 = brojevi;
			
			foreach (var e in brojevi1)
			{
				Console.WriteLine("\"{0}\" = {1}", e.Key, e.Value);
			}
			
		}

        public static void PridruživanjeDvijuKolekcijaSRazličitimParametrima()
        {
            Dictionary<string, string> numbers = new Dictionary<string, string>();
            numbers.Add("one", "jedan");
            numbers.Add("two", "dva");
            numbers.Add("three", "tri");

			// Otkomentirati donju naredbu i provjerite pogrešku koju prevoditelj prijavljuje.
			//brojevi=numbers;
			// "The name 'brojevi does not exist in current context'"
			
			Dictionary<string,int> brojevi = new Dictionary<string, int>();
			//brojevi = numbers; //Nije dozvoljeno pridruživanje sa parametrima različith tipova
			 /*
			Cannot implicitly convert type 'System.Collections.Generic.Dictionary<string, string>' 
			to 'System.Collections.Generic.Dictionary<string, int>'
			*/

			brojevi.Add("jedan", 1);
			brojevi.Add("dva", 2);
			brojevi.Add("tri", 3);
			

			foreach (var e in numbers)
            {
                Console.WriteLine("\"{0}\" = {1}", e.Key, e.Value);
            }
        }


        static void Main(string[] args)
        {
            PridruživanjeDvijuKolekcijaSIstimParametrima();

          //  PridruživanjeDvijuKolekcijaSRazličitimParametrima();

            Console.WriteLine("Gotovo!!!");
            Console.ReadKey();
        }
    }
}
