using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class PersonalCrediManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ihtiyac Kredisi Odeme Plani Hesaplandi!");
        }

        public void Update()
        {
            Console.WriteLine("Ihtiyac Kredisi Odeme Plani Guncellendi!");
        }
    }
}
