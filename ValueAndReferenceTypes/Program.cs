using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] 999
            Console.WriteLine(sayilar1[0]);


            //int,decimal,float,double,bool -> value type
            //array,class,interface -> reference type
            //Bellekte stack ve heap tipleri vardir.
            //sayi1 ve sayi2 deger tiptir ve stack'de tanimlanir.



            Console.ReadLine();
        }
    }
}
