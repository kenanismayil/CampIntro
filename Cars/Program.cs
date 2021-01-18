using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = "Cars Information:";

            Brands car1 = new Brands();
            car1.AutoMark = "Range Rover";
            car1.Location = "Baku";
            car1.Price = 152000;
            car1.Year = 2020;

            Brands car2 = new Brands();
            car2.AutoMark = "Nissan Murano";
            car2.Location = "Baku";
            car2.Price = 24300;
            car2.Year = 2013;

            Brands car3 = new Brands();
            car3.AutoMark = "BMW 545";
            car3.Location = "Gence";
            car3.Price = 17500;
            car3.Year = 2005;

            Brands car4 = new Brands();
            car4.AutoMark = "Hyundai Tucson";
            car4.Location = "Baku";
            car4.Price = 30000;
            car4.Year = 2019;

            Brands[] products = new Brands[] {car1,car2,car3,car4 };

            Console.WriteLine(info);
            Console.WriteLine("---------------------");
            foreach (var cars in products)
            {
                Console.WriteLine(cars.AutoMark);
                Console.WriteLine(cars.Location);
                Console.WriteLine(cars.Price);
                Console.WriteLine(cars.Year);

                Console.WriteLine("----------------------------------");
            }

            CarsManager automobile = new CarsManager();
            automobile.Add1(car1);
            automobile.Add1(car2);

            Console.WriteLine("----------------------------------");

            automobile.Add2(car3);
            automobile.Add2(car4);

            Console.WriteLine("----------------------------------");

            automobile.Add3(car1);
            automobile.Add3(car2);
            automobile.Add3(car3);
            automobile.Add3(car4);

            Console.WriteLine("----------------------------------");

            Console.ReadLine();
        }
    }
}
