using System.Collections.Generic;

namespace CustomerDetails.ViewModels
{
    public class CustomerListViewModel
    {
        public IEnumerable<CustomerListItemViewModel> Customers { get; set; }
    }

    public class CustomerListItemViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}