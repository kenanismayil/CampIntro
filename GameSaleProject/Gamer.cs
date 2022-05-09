using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject
{
    class Gamer
    {
        //User Base class tanimlayip, bu class'a inherit edilebilirdi!!!
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long IdentityNumber { get; set; }
        public int BirthYear { get; set; }
        public double Balance { get; set; }
    }
}
