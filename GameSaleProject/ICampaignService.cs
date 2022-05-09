using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject
{
    interface ICampaignService
    {
        void NewCampaignAdd(Gamer gamer);
        void UpdateCampaign(Gamer gamer);
        void DeleteCampaign(Gamer gamer);
    }
}
