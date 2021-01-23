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
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product() { Id = 2, CategoryId = 5,
                 UnitsInStock = 5, ProductName = "Pen", UnitPrice = 35 };

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);

            productManager.Addition2(3, 6);

            //return sayesinde Addition() metotdun icersindeki degeri dondurerek main icerisinde tekrar kullanabiliriz.
            int additionResult = productManager.Addition(3, 6);    //Metot icersindeki aldigimiz return degerini kullanmak istersek boyle yapariz.
            Console.WriteLine(additionResult * 2);

            //int,double,bool.... -> Value Type
            //arrays,classes,abstract classes,interface... -> Reference Type
            Console.ReadLine();

        }
    }
}
