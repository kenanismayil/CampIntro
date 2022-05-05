using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,double,float,decimal,bool...  -> Deger Tipler
            //array,class,struct,abstract,interface... -> Referans Tipler

            //Deger Tipler
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;                  //30
            sayi2 = 65;
            Console.WriteLine(sayi1);       //30


            //Referans Tipler
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

            int num1=90;
            int num2 = 60;
            var result = Add(ref num1, num2);
            Console.WriteLine(num1);

            //int num1;
            //int num2 = 60;
            //var result = Add(out num1, num2);
            //Console.WriteLine(num1);


            Console.ReadKey();
        }

        private static object Add(ref int num1, int num2)
        {
            num1 = 70;
            return num1 + num2;
        }
    }
}
