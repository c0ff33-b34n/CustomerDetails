using System;
using System.Collections.Generic;
using CustomerDetails.DataLayer;
using CustomerDetails.Models;

namespace CustomerDetails.DomainLayer.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;
        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        public void Add(Customer customer)
        {
            _repo.Insert(customer);
        }

        public IEnumerable<Customer> All()
        {
            return _repo.All();
        }

        public void Delete(int customerId)
        {
            _repo.DeleteById(customerId);
        }

        public Customer Find(int customerId)
        {
            return _repo.FindById(customerId);
        }

        public void Update(Customer customer)
        {
            _repo.Update(customer);
        }

    }
}