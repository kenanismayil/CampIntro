using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " -> " + "Is Added");
        }
        
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " -> " + "Is Updated");
        }

        public int Addition(int sayi1,int sayi2)
        {          
            int result = sayi1 + sayi2;
            return result;
        }

        public void Addition2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
