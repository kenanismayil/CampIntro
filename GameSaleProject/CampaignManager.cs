using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject
{
    class CampaignManager : ICampaignService
    {

        public void NewCampaignAdd(Gamer gamer)
        {
            Console.WriteLine("Yillik %30 kupon hesabiniza eklendi!");
        }

        public void UpdateCampaign(Gamer gamer)
        {
            Console.WriteLine("Kampmanya bir sonraki yil 23:59'a kadar gecerlidir!");
        }
        public void DeleteCampaign(Gamer gamer)
        {
            Console.WriteLine("Kupon sureniz doldugu icin silinmistir!");
        }
    }
}
