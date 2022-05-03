using System;

namespace ProductManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Gender = "Erkek";
            product1.Catalog = "Kolye";
            product1.ProductName = "3'lu Kare Burgu Ve Orme Zincir Kolye Seti";
            product1.SellerShop = "Dukkanka";
            product1.Price = 29.83;
            product1.StockNumber = 2;
            product1.DiscountRate = 0;

            Product product2 = new Product();
            product2.Gender = "Erkek";
            product2.Catalog = "Kolye";
            product2.ProductName = "Triagle Ok Ucu Erkek Fume Kolye";
            product2.SellerShop = "Baykus";
            product2.Price = 17.50;
            product2.StockNumber = 5;
            product2.DiscountRate = 10;

            Product product3 = new Product();
            product3.Gender = "Erkek";
            product3.Catalog = "Kolye";
            product3.ProductName = "Erkek Celik Kolye Kup Ucgen Model Zincir";
            product3.SellerShop = "Alpha Silver";
            product3.Price = 29.29;
            product3.StockNumber = 7;
            product3.DiscountRate = 5;

            Product product4 = new Product();
            product4.Gender = "Erkek";
            product4.Catalog = "Yuzuk";
            product4.ProductName = "Heart Decor Yuzuk";
            product4.SellerShop = "Carpe";
            product4.Price = 25.90;
            product4.StockNumber = 3;
            product4.DiscountRate = 10;

            Product product5 = new Product();
            product5.Gender = "Erkek";
            product5.Catalog = "Yuzuk";
            product5.ProductName = "Antik Gumus Kaplama Ayarlanabilir Yuzuk Seti";
            product5.SellerShop = "Tesbih Otagi";
            product5.Price = 85.40;
            product5.StockNumber = 8;
            product5.DiscountRate = 20;

            Product product6 = new Product();
            product6.Gender = "Erkek";
            product6.Catalog = "Yuzuk";
            product6.ProductName = "Tugla Desenli Kare Oniks Tasli 925 Gumus Erkek Yuzuk";
            product6.SellerShop = "ALYANSEVIM";
            product6.Price = 167.90;
            product6.StockNumber = 12;
            product6.DiscountRate = 30;


            Product[] products = new Product[] 
            {
                product1,
                product2,
                product3,
                product4,
                product5,
                product6
            };

            Console.WriteLine("-----------------------Product List------------------------\n");

            foreach (var product in products)
            {
                Console.WriteLine($"Gender : {product.Gender}");
                Console.WriteLine($"Catalog : {product.Catalog}");
                Console.WriteLine($"Product Name : {product.ProductName}");
                Console.WriteLine($"Seller Shop : {product.SellerShop}");
                Console.WriteLine($"Price : {product.Price}");
                Console.WriteLine($"Stock Number : {product.StockNumber}");
                Console.WriteLine($"Discount Rate : {product.DiscountRate}");
                Console.WriteLine("--------------------------------------------------------------------");
            }

            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine
            //        (
            //            "Gender : " + products[i].Gender +
            //            "\nCatalog : " + products[i].Catalog + 
            //            "\nProduct Name : " + products[i].ProductName +
            //            "\nSeller Shop : " + products[i].SellerShop +
            //            "\nPrice : " + products[i].Price +
            //            "\nStock Number : " + products[i].StockNumber +
            //            "\nDiscount Rate : " + products[i].DiscountRate
            //        );
            //    Console.WriteLine("-----------------------------------------");
            //}


            //int i = 0;
            //while (i < products.Length)
            //{
            //    Console.WriteLine
            //        (
            //            "Gender : " + products[i].Gender +
            //            "\nCatalog : " + products[i].Catalog +
            //            "\nProduct Name : " + products[i].ProductName +
            //            "\nSeller Shop : " + products[i].SellerShop +
            //            "\nPrice : " + products[i].Price +
            //            "\nStock Number : " + products[i].StockNumber +
            //            "\nDiscount Rate : " + products[i].DiscountRate
            //        );
            //    Console.WriteLine("-----------------------------------------");
            //    i++;
            //}


        }
    }


    class Product
    {
        public string Gender { get; set; }
        public string Catalog { get; set; }
        public string ProductName { get; set; }
        public string SellerShop { get; set; }
        public double Price { get; set; }
        public int StockNumber { get; set; }
        public int DiscountRate { get; set; }

    }
}
