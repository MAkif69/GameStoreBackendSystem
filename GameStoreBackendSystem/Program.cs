using GameStoreBackendSystem.Abstract;
using GameStoreBackendSystem.Adapter;
using System;

namespace GameStoreBackendSystem
{
    class Program
    {
        static void Main(string[] args)
        {


            Customer customer = new Customer {Id=1,FirstName="*",LastName="*",
            BirthTime=new DateTime(*),NationaltiyId="*"};

            BaseCustomerManager baseCustomerManager = new CustomerManager(new CustomerAdapterService());
            baseCustomerManager.Add((Customer)customer);
            
        }
    }
}
