using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        //Naming Convention -> Isimlendirme Kurali -> Ekle()
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.Name);
        }

        public void Ekle2(string productName, double price, string explanation, int stockNumber)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + productName);

        }

    }
}
