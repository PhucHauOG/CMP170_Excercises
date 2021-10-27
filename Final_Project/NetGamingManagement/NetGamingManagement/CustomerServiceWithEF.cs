using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGamingManagement
{
    public class CustomerServiceWithEF : ICustomerService
    {
        public CustomerServiceWithEF()
        {
            using (var ctx = new NetContext())
            {
                ctx.Database.EnsureCreated();
            }
        }

        public void DeleteCustomerById(int id)
        {
            using (var ctx = new NetContext())
            {
                var deletedCustomer = ctx.Customers.Find(id);
                ctx.Customers.Remove(deletedCustomer);
                ctx.SaveChanges();
            }
        }

        public Customer LoadCustomerById(int id)
        {
            using (var ctx = new NetContext())
            {
                return ctx.Customers.Find(id);
            }
        }

        public IList<Customer> SearchCustomer(string keyword)
        {
            using (var ctx = new NetContext())
            {
                var result = ctx.Customers.Where(c => (c.FirstName == keyword || string.IsNullOrEmpty(keyword)))
                                    .OrderBy(c => c.CustomerId).ToList();
                return result;
            }
        }

        public void UpdateOrCreateCustomer(Customer customer)
        {
            using (var ctx = new NetContext())
            {
                if (customer.CustomerId > 0)
                {
                    var dbCustomer = ctx.Customers.Find(customer.CustomerId);
                    dbCustomer.FirstName = customer.FirstName;
                    dbCustomer.LastName = customer.LastName;
                    dbCustomer.Account = customer.Account;
                    dbCustomer.Email = customer.Email;
                    dbCustomer.Phone = customer.Phone;
                }
                else
                {
                    ctx.Customers.Add(customer);
                }
                ctx.SaveChanges();
            }
        }
    }
}
