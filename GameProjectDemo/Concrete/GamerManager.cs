using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GamerManager : IGamerService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Save(Gamer gamer)
        {
            if (CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + "saved.");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
