using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Invidual Client
    class InvidualClient:Client         //Inheritance -> Invidual Client de bir Client'tir. Client'ten miras alinir.
    {
        public string Name { get; set; }           
        public string Surname { get; set; }
        public string TcNo { get; set; }
    }
}
