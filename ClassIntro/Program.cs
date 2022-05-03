using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Kenan";
            int yas = 22;


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 53;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varis";
            kurs2.IzlenmeOrani = 63;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 83;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtbogan";
            kurs4.IzlenmeOrani = 100;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };         //Gercekte veri tabanindan gelir.

            //kurs = alias'tir. Yani takma isimdir. Her dongude dizinin farkli elemanlarina karsilik gelir. Or: (kurs = kurs1, kurs = kurs2, kurs = kurs2)
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            Console.WriteLine("------------------------------");



            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            Console.WriteLine(kurs2.KursAdi + " : " + kurs2.Egitmen);
            Console.WriteLine(kurs3.KursAdi + " : " + kurs3.Egitmen);



            Console.ReadKey();
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
