using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figura figura1 = new Figura();
            //Kwadrat kwadrat1 = new Kwadrat(5);
            //Console.WriteLine(kwadrat1.ObliczPole());
            //Trojkat trojkat1 = new Trojkat(3, 4, 5);
            //Console.WriteLine(trojkat1.ObliczPole());


            List<Figura> figury = new List<Figura>();
            figury.Add(new Kwadrat(6));
            figury.Add(new Trojkat(4,6,7));
            figury.Add(new Kwadrat(3.2));
            figury.Add(new Trojkat(5, 3, 7));
            figury.Add(new Kwadrat(7.2));
            figury.Add(new Trojkat(8, 6.2, 7.3));
            foreach(var element in figury)
            {
                Console.WriteLine(element.ObliczPole());
            }
            Console.ReadKey();
        }
    }
}
