using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)//101 ->productun referans adresi parametre olarak gonderilir.
        {
            product.ProductName = " Kamera";
            Console.WriteLine(product.ProductName + " eklendi!");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " guncellendi!");
        }


    }
}
