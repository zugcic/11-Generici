using System;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: U datoteci Životinja.cs definirati apstraktnu klasu Životinja s apstraktnom (dakle virtualnom!) metodom void PokreniSe(). Proglasiti tu klasu baznom klasom za klase Gmaz, Ptica, Riba i Sisavac te prilagoditi potpise njiovih metoda PokreniSe. Prevesti program i provjeriti da nema pogrešaka.

            List<Životinja> živine = new List<Životinja>();
            živine.Add(new Ptica());
            živine.Add(new Gmaz());
            živine.Add(new Sisavac());
            živine.Add(new Riba());

            // TODO: U donjoj petlji pozvati metodu PokreniSe za svaki element kolekcije. Prevesti i pokrenuti program te provjeriti da ispis odgovara za svaku pojedinu životinju.

            foreach (var živina in živine)
                Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
