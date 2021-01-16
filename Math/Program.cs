using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            FourOperation fourOperation = new FourOperation();
            fourOperation.Addition(2, 3);               //Parametreler degisken degerlerdir.Istedigimiz kadar degerleri degisebiliriz.

            fourOperation.Addition(5, 7);

            Console.ReadLine();
        }
    }
}
