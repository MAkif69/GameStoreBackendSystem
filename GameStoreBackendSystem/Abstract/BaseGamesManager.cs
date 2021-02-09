using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackendSystem.Abstract
{
    class BaseGamesManager : IStoreManager<Games, int>
    {
        public virtual void Add(Games games)
        {
            Console.WriteLine("Gamed added"+games.GameName);
        }

        public virtual void Delete(Games games)
        {
            Console.WriteLine("Gamed deleted" + games.GameName);
        }

        public virtual void Updtae(Games games)
        {
            Console.WriteLine("Gamed deleted" + games.GameName);
        }
    }
}
