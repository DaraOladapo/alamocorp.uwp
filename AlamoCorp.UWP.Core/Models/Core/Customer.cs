

namespace AlamoCorp.UWP.Core.Models.Core
{
    public class Customer
    {
       
        public long CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
