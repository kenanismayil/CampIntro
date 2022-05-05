using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //Farkli Kullanim
            Product product2 = new Product 
            {
                Id = 2, 
                CategoryId = 5, 
                ProductName = "Kalem", 
                UnitPrice = 45, 
                UnitsInStock = 5 
            };


            //Urun ekleme 
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);



            Console.ReadKey();
        }
    }
}
