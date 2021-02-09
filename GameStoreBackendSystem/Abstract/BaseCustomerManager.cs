using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackendSystem.Abstract
{
    class BaseCustomerManager : IStoreManager<Customer, int>
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine("Customer added : " +"\n"+ customer.FirstName);
        }

        public virtual void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted" + customer.FirstName);
        }

        public virtual void Updtae(Customer customer)
        {
            Console.WriteLine("Customer updated" + customer.FirstName);
        }
    }
}
