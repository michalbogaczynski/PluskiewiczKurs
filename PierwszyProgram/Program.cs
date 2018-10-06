using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.AkceptujDetale();
            r.WyswietlPodsumowanie();
            Console.ReadKey();

        }
    }

    class Rectangle
    {
        double dlugosc;
        double szerokosc;

        public void AkceptujDetale()
        {
            dlugosc = 10;
            szerokosc = 20;
        }

        public double ObliczPowierzchnie()
        {
            return dlugosc * szerokosc;
        }

        public void WyswietlPodsumowanie()
        {
            Console.WriteLine("Długość: {0}", dlugosc);
            Console.WriteLine("Szerokość: {0}", szerokosc);
            Console.WriteLine("Powierzchnia: {0}", ObliczPowierzchnie());
        }

    }

}
