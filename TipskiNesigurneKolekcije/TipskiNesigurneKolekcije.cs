using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // primjer korištenja "obične" liste koja pohranjuje reference na System.Object
            try
            {
                ArrayList osobe = new ArrayList();
                osobe.Add(new Osoba("Marica", new DateTime(1989, 12, 1)));
                osobe.Add(new Osoba("Ivica", new DateTime(1993, 4, 2)));
                // dodajemo drugačiji tip - ova naredba će proći
                // i podatak će biti pohranjen u listu...
                osobe.Add(DateTime.Now);

                // TODO: Pokrenuti program i provjeriti što će se ispisati. Ispis prekopirati u datoteku "TipskiNesigurneKolekcije1.txt".


                // TODO: Umjesto da ispisuje objekt osoba, donju petlju promijeniti tako da u naredbi Console.WriteLine ispisuje član 'Ime' za svaku osobu. Pokreniti program, a ispis prekopirati u datoteku "TipskiNesigurneKolekcije2.txt"

                foreach (var osoba in osobe)
                {
                    Console.WriteLine(osoba);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Gotovo!!!");
            Console.ReadLine();
        }
    }
}
