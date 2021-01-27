using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class SaleManager : ISaleService
    {
        public void CampaignSale(Campaign campaign, Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + "bought" + " " + game.Name + " " + "from " + " " + campaign.Name);
        }

        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + "bought" + " " + game.Name);
        }
    }
}
