using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic Kampi";
            string kurs3 = "Java";
            string kurs4 = "Pyhton";

            //Ekranda Manuel Sekilde Gosterir.
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            Console.WriteLine("-----------------------");


            //Array (Dizi) -> Ekrani Dinamiklestirir!
            string[] kurslar = new string[] 
            {
                "Yazilim Yetistirme Kampi",
                "Programlamaya baslangic Kampi",
                "Java",
                "Pyhton",
                "C#"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti.");


            Console.WriteLine("-------------------------------");


            //Foreach yapisi -> Dizilerin elemanlarini kolaylikla tek tek dolasmasini saglar.
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Foreach Bitti.");


            Console.ReadKey();
        }
    }
}
