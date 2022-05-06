using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Corporate Client
    class CorporateClient:Client        //Inheritance -> Corporate Client bir Client'tir. Client'ten miras alinir.
    {
        public string CompanyName { get; set; }     //Corporate Client (Sirkete ait)
        public string TaxNo { get; set; }           //Sirkete ait Musteriyse vergi(tax) no'su vardir.
    }
}
