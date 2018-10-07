using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonwersjaTypow
{
    class Program
    {
        static void Main(string[] args)
        {
            //niejawna konwersja danych (bezpieczna)
            int wartosc1 = 0;
            byte wartosc2 = 15;

            wartosc1 = wartosc2; //wartosc2 przypisana jest do wartosci1 czyli wartosc1=15
            Console.WriteLine(wartosc2);
            Console.WriteLine(34 + 34.5); //z automatu wartość bedzie zmiennoprzecinkowa
            

            //konwersja jawna

            double liczba = 3765.47;
            int i;
            i = (int)liczba;
            Console.WriteLine(i);


            int j = 32;
            float f = 32.005f;
            double d = 1234 / 5678;
            bool b = false;
            Console.WriteLine(j.ToString());
            Console.WriteLine(f.ToString());

            Console.ReadKey();
        }
    }
}
