using System.Linq;
using CustomerDetails.DomainLayer;
using CustomerDetails.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CustomerDetails.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var customers =  _customerService.All();

            var viewModel = new CustomerListViewModel
            {
                Customers = customers.Select(customer => new CustomerListItemViewModel
                {
                    Id = customer.Id,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName
                })
            };
            return View(viewModel);
        }
    }
}