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


            int a = 50;
            int b = 30;
            b = a;
            a = 45;
            Console.WriteLine(b);
            Console.WriteLine(a);

            int[] c = new int[] {1,2,3,4,5,6,7,8,0,5,8 };
            int[] d = new int[] { 8, 9, 4, 6, 5, 3, 32, 43, 34, 58 };

            d=c;
            c[0] = 12;

            Console.WriteLine(d[0]);

            Console.ReadLine();
        }
    }
}
