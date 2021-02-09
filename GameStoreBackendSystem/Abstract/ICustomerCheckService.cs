using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackendSystem.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckRealPerson(Customer customer);
    }
}
