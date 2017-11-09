using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba student1 = new Student("Jan", "Kowalski",1,1,12345);
            Console.WriteLine(student1.ToString());


            Console.ReadKey();
        }
    }
}
