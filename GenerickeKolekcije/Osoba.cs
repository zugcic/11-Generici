using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    class Osoba
    {
        public Osoba(string ime, DateTime datumRodjenja)
        {
            Ime = ime;
            DatumRodjenja = datumRodjenja;
        }

        public readonly string Ime;
        public readonly DateTime DatumRodjenja;
    }
}
