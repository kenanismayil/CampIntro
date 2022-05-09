using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject
{
    class OrderManager : IOrderService
    {
        //OrderManager'e Campaign entegre edildi.
        ICampaignService _campaignService;

        //Constructor
        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Sale(Gamer gamer)
        {
            Console.WriteLine($"<{gamer.UserName}> adli kullanici oyunu aldi!");
            _campaignService.NewCampaignAdd(gamer);    
        }

        public void PayBack(Gamer gamer)
        {
            Console.WriteLine($"<{gamer.UserName}> adli kullanici oyunu geri iade etti!");
        }
     
    }
}
