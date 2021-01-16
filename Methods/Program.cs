using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string productName = "Apple";   
            //double price = 15;                              //Class bu uc bilgiyi bir urun nesnesi(elma) olarak anlatir soylenebilir.
            //string explanation = "Amasya apple";
            //string[] fruits = new string[] { Apple,Watermelon };    //Tek tek yazmamiz gerekiyor boyle :(

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Explanation = "Amasya Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Explanation = "Diyarbakir Watermelon";

            Product[] products = new Product[] { product1,product2 };

            //Type-safe -- tip guvenli 
            foreach (var product in products)
            {

                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine("--------------Methods-----------------------");

            //Instance -> class ornegi olusturma
            //Encapsulation
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);                                    //Function Method is calling
            basketManager.Add(product2);

            basketManager.Add2("Grapes","Green",12,10);
            basketManager.Add2("Apple", "Green apple", 12,9);
            basketManager.Add2("WAtermelon", "Green", 12,8);

            Console.ReadLine();
        }
    }
}



//Do not repeat yourself! -> DRY -> Clean Code -> Best Practice