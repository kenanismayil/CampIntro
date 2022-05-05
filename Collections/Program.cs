using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deger tipler sadece steack kullanir. Referans tipler hem stack, hem de heap kullanir.

            //stack -> names, heap -> [Engin,Murat,Kerem,Halit] -> adress:101(stackdeki names degiskenin adresi 101 olur)
            //Arrays
            //string[] names = new string[] { "Engin", "Murat", "Kerem", "Halit" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];      //Adress degisildi.Yeni adress or: 102 oldu. Bu yuzden eski adresin degerleri adresle birlikte silindi.

            //names[4] = "Kenan";
            //Console.WriteLine(names[4]);        //Boyle bir yer yoktur. Tanimlanan dizinin boyutu disinda old icin hata verir.
            //Console.WriteLine(names[0]);        //Dizileri genisletemeyiz. Adresini degistirip yeni adrese tasidik. Eski adres silindi.

            //Collections
            //Lists 
            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem","Halit" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            //Kolleksiyonlarda arrayler gibi degerlerimizi kaybetmemizi engelleyecek bir altyapi vardir!
            names2.Add("Kenan");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[2]);


            Console.ReadKey();
        }
    }
}
