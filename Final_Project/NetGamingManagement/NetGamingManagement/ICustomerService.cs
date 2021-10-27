using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGamingManagement
{
    public interface ICustomerService
    {
        IList<Customer> SearchCustomer(string keyword);

        Customer LoadCustomerById(int id);

        void UpdateOrCreateCustomer(Customer customer);

        void DeleteCustomerById(int id);
    }
}
