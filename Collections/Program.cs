using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nouns = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(nouns[0]);
            Console.WriteLine(nouns[1]);
            Console.WriteLine(nouns[2]);
            Console.WriteLine(nouns[3]);
            //nouns[4] = "Ilker";                //4 tane elemanli bir string dizisi tanimladigimiz icin 5ci elemani sonradan tanimlayip
            //Console.WriteLine(nouns[4]);       //ekrana yazamayiz.

            nouns = new string[5];          //Bellekte yeni bir adres olusturduk.Yeni 5 elemanli referans adresi olusturduk demek oluyor.
            nouns[4] = "Kenan";             //new demek yeni referans adresi demektir.
            Console.WriteLine(nouns[4]);
            Console.WriteLine(nouns[0]);    //nouns'un adresini degistigimiz yukardaki elemanlar kaybolur.

            //Olusturdugumuz diziler aslinda gercek hayatta bize veri tabanindan hazir olarak gelir.Sonradan eleman eklemye calissak bunu dizilerle yapamiyoruz.
            //C#'da collection denen yapilarla bunu yapabiliriz.
            //Collections----------------------------------------------------------------------------
            List<string> nouns2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(nouns2[0]);
            Console.WriteLine(nouns2[1]);
            Console.WriteLine(nouns2[2]);
            Console.WriteLine(nouns2[3]);
            Console.WriteLine(nouns2.Count);
            nouns2.Add("Kenan");                           //Add bir List fonksiyonudur.List'in baska fonksiyonlari da vardir.
            Console.WriteLine(nouns2[4]);
            Console.WriteLine(nouns2[0]);
            Console.WriteLine(nouns2.Count);              //nouns2 listesinin kac elemanli oldugunu gosterir.

            Console.ReadLine();
        }
    }
}
