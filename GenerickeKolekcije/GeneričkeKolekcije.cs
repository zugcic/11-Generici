using System;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(new Osoba("Marica", new DateTime(1989, 12, 1)));
            osobe.Add(new Osoba("Ivica", new DateTime(1993, 4, 2)));

            // TODO: Napisati naredbu kojom se u kolekciju 'osobe' dodaje objekt nekog drugog tipa, npr. DateTime.Now i provjeriti što će prevoditelj javiti.



            // TODO: U donju petlju umetnuti naredbu koja će ispisati član 'Ime' svake osobe. Pokrenuti program i provjeriti ispis.
            foreach (var osoba in osobe)
            {

            }

            Console.WriteLine("Gotovo!!!");
            Console.ReadLine();
        }
    }
}
