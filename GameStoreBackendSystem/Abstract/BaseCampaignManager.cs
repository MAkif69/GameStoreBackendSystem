using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackendSystem.Abstract
{
    public abstract class BaseCampaignManager : IStoreManager<Campaign, int>
    {
        public virtual void Add(Campaign campaign)
        {
            Console.WriteLine("Campaing added: " + "\n"+campaign.CompanyName);
        }


        public virtual void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaing deleted" + campaign.CompanyName);
        }

        public virtual void Updtae(Campaign campaign)
        {
            Console.WriteLine("Campaing updated" + campaign.CompanyName);
        }
    }
}
