using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TransportCrediManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tasit Kredisi Odeme Plani Hesaplandi!");
        }

        public void Update()
        {
            Console.WriteLine("Tasit Kredisi Odeme Plani Guncellendi!");
        }
    }
}
