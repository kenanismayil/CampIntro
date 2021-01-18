using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class CarsManager
    {
        public void Add1(Brands car)
        {
            Console.WriteLine("Barter is possible : " + car.AutoMark);
        }

        

        public void Add2(Brands car)
        {
            Console.WriteLine("Barter is impossible : " + car.AutoMark);
        }



        public void Add3(Brands car)
        {
            Console.WriteLine("Saloon : " +car.AutoMark);
        }
    }

}
