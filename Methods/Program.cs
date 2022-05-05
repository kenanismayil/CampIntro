using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metotlar -> tekrar tekrar kullanabilirligi saglayan kod bloklaridir. Or: Eticaret sitelerinde Sepet ekle kismi heryerde kullanilabilir.
            //Don't Repeat Yourself!!! - Clean Code - Best Practice

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasaya Elmasi";


            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 30;
            product2.Explanation = "Diyarbakir Karpuzu";

            //Gercek hayatta datalar bir veri kaynagindan gelir!!!
            Product[] products = new Product[] { product1, product2 };

            //Type Safety -> tip guvenli
            foreach (var product in products)
            {
                Console.WriteLine($"Name : {product.Name}");
                Console.WriteLine($"Price : {product.Price}");
                Console.WriteLine($"Explanation : {product.Explanation}");
                Console.WriteLine("-------------------------------------------------------------");
            }

            Console.WriteLine("-------------------------Metotlar-----------------------------");

            //Instance -> Class ornegi olusturmak 
            //Encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            Console.WriteLine("----------------------------");

            sepetManager.Ekle2("Armut",12,"Sari Armut",10);
            sepetManager.Ekle2("Elma", 12, "Yesil Elma",9);
            sepetManager.Ekle2("Karpuz", 12, "Kirmizi Karpuz",7);




            Console.ReadKey();
        }

        
    }
}
