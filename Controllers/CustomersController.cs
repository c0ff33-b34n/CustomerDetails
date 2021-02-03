using System.Linq;
using System.Threading.Tasks;
using CustomerDetails.DomainLayer;
using CustomerDetails.Models;
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

        public IActionResult View(int id)
        {
            var customer = _customerService.Find(id);
            var viewModel = new CustomerViewViewModel
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                BusinessName = customer.BusinessName,
                BuildingName = customer.BuildingName,
                NumberAndStreet = customer.NumberAndStreet,
                LocalityName = customer.LocalityName,
                TownOrCity = customer.TownOrCity,
                County = customer.County,
                PostCode = customer.PostCode
            };
            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCustomerViewModel model)
        {
            var customer = new Customer
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                BusinessName = model.BusinessName,
                BuildingName = model.BuildingName,
                NumberAndStreet = model.NumberAndStreet,
                LocalityName = model.LocalityName,
                TownOrCity = model.TownOrCity,
                County = model.County,
                PostCode = model.PostCode
            };

            _customerService.Add(customer);

            // Redirect back to the list
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var customer = _customerService.Find(id);
            var viewModel = new EditCustomerViewModel
            {
                Id = customer.Id,
                Form = new CustomerFormViewModel
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    BusinessName = customer.BusinessName,
                    BuildingName = customer.BuildingName,
                    NumberAndStreet = customer.NumberAndStreet,
                    LocalityName = customer.LocalityName,
                    TownOrCity = customer.TownOrCity,
                    County = customer.County,
                    PostCode = customer.PostCode
                }
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(EditCustomerViewModel model)
        {
            var customer = new Customer
            {
                Id = model.Id,
                FirstName = model.Form.FirstName,
                LastName = model.Form.LastName,
                BusinessName = model.Form.BusinessName,
                BuildingName = model.Form.BuildingName,
                NumberAndStreet = model.Form.NumberAndStreet,
                LocalityName = model.Form.LocalityName,
                TownOrCity = model.Form.TownOrCity,
                County = model.Form.County,
                PostCode = model.Form.PostCode
            };

            _customerService.Update(customer);

            // Redirect back to the list
            return RedirectToAction(nameof(Index));
        }
    }
}