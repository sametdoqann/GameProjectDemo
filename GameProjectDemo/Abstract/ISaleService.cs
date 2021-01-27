using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    interface ISaleService
    {
        void Sale(Gamer gamer, Game game);
        void CampaignSale(Campaign campaign, Game game, Gamer gamer);
    }
}
