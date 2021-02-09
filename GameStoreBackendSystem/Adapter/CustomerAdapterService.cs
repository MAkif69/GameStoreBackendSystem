using GameStoreBackendSystem.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackendSystem.Adapter
{
    class CustomerAdapterService : ICustomerCheckService
    {
        public bool CheckRealPerson(Customer customer)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationaltiyId), customer.FirstName.ToUpper(),
            //    customer.LastName.ToUpper(), customer.BirthTime.Year);

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationaltiyId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.BirthTime.Year);
            return result.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
