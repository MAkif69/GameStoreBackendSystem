using GameStoreBackendSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackendSystem
{
    public class GamesManager : IStoreManager<Games, int>
    {
        public void Add(Games games)
        {
            Console.WriteLine("Game added"+games.GameName);
        }

        public void Delete(Games games)
        {
            Console.WriteLine("Game deleted" + games.GameName);
        }

        public void Updtae(Games games)
        {
            Console.WriteLine("Game updated" + games.GameName);
        }
    }
}
