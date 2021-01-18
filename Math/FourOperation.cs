using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    class FourOperation
    {
        double result;

        public void Addition(double sayi1,double sayi2)
        {
            result = sayi1 + sayi2;
            Console.WriteLine(result);
        }

        public void Substraction1(double sayi1,double sayi2)
        {
            result = sayi1 - sayi2;
            Console.WriteLine(result);
        }

        public void Substraction2(double sayi1,double sayi2)
        {
            if (sayi1>sayi2)
            {
                result = sayi1 - sayi2;
            }
            else
            {
                result = sayi2 - sayi1;
            }

            Console.WriteLine(result);
        }

        public void Multiplication(double sayi1,double sayi2)
        {
            result = sayi1 * sayi2;
            Console.WriteLine(result);
        }

        public void Division(double sayi1,double sayi2)
        {
            result = sayi1 / sayi2;
            Console.WriteLine(result);
        }

    }
}
