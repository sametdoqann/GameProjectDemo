using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer() { Id = 1, FirstName = "Samet", LastName = "Doğan", NationalityId = "12345678910", DateOfBirth = new DateTime(1998, 1, 1) };
            Gamer gamer2 = new Gamer() { Id = 2, FirstName = "Enes", LastName = "Doğan", NationalityId = "12345678911", DateOfBirth = new DateTime(1999, 1, 1) };
            GamerManager gamerManager = new GamerManager();
            gamerManager.Save(gamer1);

            Game game1 = new Game() { Id = 1, Name = "Counter Strike: Global Offensive", Price = 80.25 };
            Game game2 = new Game() { Id = 2, Name = "PUBG", Price = 120.75 };
            SaleManager sale = new SaleManager();
            sale.Sale(gamer2, game1);

            Campaign campaign1 = new Campaign() { Id = 1, Name = "New Year Campaign", StartingDate = new DateTime(2020, 12, 12), EndDate = new DateTime(2021, 1, 2) };
            Campaign campaign2 = new Campaign() { Id = 2, Name = "Halloween", StartingDate = new DateTime(2021, 10, 22), EndDate = new DateTime(2021, 10, 26) };
            SaleManager sale2 = new SaleManager();
            sale2.CampaignSale(campaign1, game2, gamer1);



        }
    }
}
