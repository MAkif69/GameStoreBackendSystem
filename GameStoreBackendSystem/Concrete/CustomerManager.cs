using GameStoreBackendSystem.Abstract;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackendSystem
{
    internal class CustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckRealPerson(customer))
            {
                base.Add(customer);
            }
            else
            {
                throw new Exception("Not a vaild Person");
            }
        }
        public override void Delete(Customer customer)
        {
            base.Delete(customer);
        }
        public override void Updtae(Customer customer)
        {
            base.Updtae(customer);
        }
    }
}
