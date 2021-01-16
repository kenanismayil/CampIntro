using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type Safety (tip guvenligi)
            //Do not repeat yourself
            //kategori etiketi deger tutucudur(alias).
            string kategoriEtiketi = "Kategori";    //Degerler veri kaynagindan gelirler.
            int ogrenciSayisi = 32000;              //Aslinda bu degerleri olayi ogrenmek icin kafadan degerler veriyoruz.
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi Butonu");
            }


            //if (sistemeGirisYapmisMi == true)
            //{
            //    Console.WriteLine("Kullanici Ayarlari Butonu");
            //}
            //else
            //{
            //    Console.WriteLine("Giris Yap Butonu");
            //}


            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);

            Console.ReadLine();
        }
    }
}
