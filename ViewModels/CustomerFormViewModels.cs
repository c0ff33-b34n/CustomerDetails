namespace CustomerDetails.ViewModels
{
    public class CreateCustomerViewModel : CustomerFormViewModel
    {

    }

    public class EditCustomerViewModel
    {
        public int Id { get; set; }
        public CustomerFormViewModel Form { get; set; }

    }

    public class CustomerFormViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BusinessName { get; set; }
        public string BuildingName { get; set; }
        public string NumberAndStreet { get; set; }
        public string LocalityName { get; set; }
        public string TownOrCity { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
    }
}