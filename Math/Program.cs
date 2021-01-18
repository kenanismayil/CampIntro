using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            FourOperation fourOperation = new FourOperation();

            Console.WriteLine("Result:");
            

            fourOperation.Addition(2, 3);                               //Parametreler degisken degerlerdir.Istedigimiz kadar degerleri degisebiliriz.
            fourOperation.Addition(5, 7);

            fourOperation.Substraction1(4, 5);
            fourOperation.Substraction2(4, 5);

            fourOperation.Multiplication(5, 9);
            fourOperation.Division(5,8);



            Console.ReadLine();
        }
    }
}
