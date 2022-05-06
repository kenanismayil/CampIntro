using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class SmallBusinessCrediManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi Odeme Plani Eklendi!");
        }

        public void Update()
        {
            Console.WriteLine("Esnaf Kredisi Odeme Plani Guncellendi!");
        }
    }
}
