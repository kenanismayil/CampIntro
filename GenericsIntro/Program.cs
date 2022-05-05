using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> sehirler = new List<string>();
            sehirler.Add("Baku");
            sehirler.Add("Istanbul");
            Console.WriteLine("Sehir sayisi : " + sehirler.Count);

            Console.WriteLine("-----------------------");

            MyList<string> names = new MyList<string>();
            names.Add("Kenan");
            names.Add("Ismayil");
            names.Add("Tofiq");
            names.Add("Sukru");
            Console.WriteLine("Isim Sayisi : " + names.Count);


            


            Console.ReadKey();
        }
    }
}
