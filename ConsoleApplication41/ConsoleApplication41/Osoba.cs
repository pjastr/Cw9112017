using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Osoba
    {
        private string imie;
        private string nazwisko;

        public Osoba()
        {

        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }


        public override string ToString()
        {
            return string.Format("Imię i nazwisko: {0} {1}", imie, nazwisko);
        }

    }
}
