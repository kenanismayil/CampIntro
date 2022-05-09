using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject
{
    interface IOrderService
    {
        void Sale(Gamer gamer);
        void PayBack(Gamer gamer);
    }
}
