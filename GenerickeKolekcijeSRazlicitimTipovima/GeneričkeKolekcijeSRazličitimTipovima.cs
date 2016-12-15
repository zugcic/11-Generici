using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    public class GeneričkeKolekcijeSaČlanovimaRazličitihTipova
    {
		
        public static void KretanjeŽivotinja()
        {
            // TODO: U datoteci Životinja.cs definirati apstraktnu klasu Životinja s apstraktnom (dakle virtualnom!) metodom void PokreniSe(). Proglasiti tu klasu baznom klasom za klase Gmaz, Ptica, Riba i Sisavac te prilagoditi potpise njihovih metoda PokreniSe.
            // TODO: Klasu ArrayList nadomjestiti generičkom listom Array<T>. Otkomentirati naredbu u petlji, prevesti program i provjeriti da nema pogrešaka.
            List<Životinja> živine = new List<Životinja>();
            živine.Add(new Ptica());
            živine.Add(new Gmaz());
            živine.Add(new Sisavac());
            živine.Add(new Riba());

            foreach (var živina in živine)
            {
                živina.PokreniSe();
            }
        }

        static void Main(string[] args)
        {
            KretanjeŽivotinja();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
