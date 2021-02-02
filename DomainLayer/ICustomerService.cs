using System.Collections.Generic;
using CustomerDetails.Models;

namespace CustomerDetails.DomainLayer
{
    public interface ICustomerService
    {
        IEnumerable<Customer> All();
        Customer Find(int customerId);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int customerId);
    }
}