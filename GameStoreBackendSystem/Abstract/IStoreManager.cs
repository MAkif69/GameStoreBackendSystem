using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackendSystem.Abstract
{
    public interface IStoreManager<TEntity,TKey>
             
        where TEntity : class
    {
        
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Updtae(TEntity entity);
    }
}
