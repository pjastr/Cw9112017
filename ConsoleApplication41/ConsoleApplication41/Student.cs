using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Student:Osoba
    {
        private int rok;
        private int numerGrupy;
        private int numerAlbumu;

        public Student()
        {

        }

        public Student(string imie, string nazwisko, int rok, int numerGrupy, int numerAlbumu)
            :base(imie, nazwisko)
        {
            this.rok = rok;
            this.numerAlbumu = numerAlbumu;
            this.numerGrupy = numerGrupy;
        }



        public override string ToString()
        {
            return base.ToString()+Environment.NewLine+string.Format("Rok studiów {0}", rok)+Environment.NewLine+string.Format("Numer grupy {0}", numerGrupy)+Environment.NewLine+string.Format("Numer albumu {0}", numerAlbumu);
        }
    }
}
