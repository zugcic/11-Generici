using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    public class GeneričkeKolekcije
    {
        public static void TipskiNesigurnaKolekcija()
        {
            ArrayList osobe = new ArrayList();
			//  U listu 'osobe' dodati dvije osobe s imenima "Ivica" i "Marica" te proizvoljnim datumima rođenja. Prevesti program, pokrenuti ga i provjeriti ispis.
			Osoba ivica = new Osoba("Ivica", new DateTime(1873, 11, 2));
			Osoba marica = new Osoba("Marica", new DateTime(1875, 11, 2));
			osobe.Add(ivica);
			osobe.Add(marica);

            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);

			// TODO: U listu 'osobe' dodati objekt nekog drugog tipa. Prevesti program, pokrenuti ga i provjeriti ispis.
			osobe.Add(3);
            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);
        }

        public static void GeneričkaKolekcija()
        {
            List<Osoba> osobe = new List<Osoba>();
			// TODO: Ponoviti dodavananja i ispise iz gornje metode. Prevesti program, pokrenuti ga i provjeriti ispis.
			Osoba ivica = new Osoba("Ivica", new DateTime(1873, 11, 2));
			Osoba marica = new Osoba("Marica", new DateTime(1875, 11, 2));
			osobe.Add(ivica);
			osobe.Add(marica);

			foreach (Osoba osoba in osobe)
				Console.WriteLine(osoba.Ime);

			// TODO: U listu 'osobe' dodati objekt nekog drugog tipa. Prevesti program, pokrenuti ga i provjeriti ispis.
			//osobe.Add(3);
			foreach (Osoba osoba in osobe)
				Console.WriteLine(osoba.Ime);
		}

        static void Main(string[] args)
        {
            Console.WriteLine("TipskiNesigurnaKolekcija:");
            try
            {
                TipskiNesigurnaKolekcija();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("GeneričkaKolekcija:");
            GeneričkaKolekcija();

            Console.WriteLine("Gotovo!!!");
            Console.ReadKey();
        }
    }
}
