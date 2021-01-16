using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        //Bunlar bir operasyon tutarlar(Managerler)

        //Naming Convention
        public void Add(Product product)                                    //Function Metot calisiyor demektir.Parantez icindeki parametredir.
        {
            Console.WriteLine("Congratulations. Basket added : " + product.Name);
        }

        public void Add2(string productName,string explanation,double price,int stokadet)
        {
            Console.WriteLine("Congratulations. Basket added : " + productName);
        }

    }
}
