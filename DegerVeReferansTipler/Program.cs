using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;                  //30
            sayi2 = 65;
            Console.WriteLine(sayi1);       //30


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 34;
            sayilar2[1] = 45;
            sayilar2[2] = 78;


            foreach (var sayi in sayilar1)
            {
                Console.WriteLine(sayi);
            }



            Console.ReadKey();
        }
    }
}
