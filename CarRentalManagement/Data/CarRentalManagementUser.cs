using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement.Data
{
    public class CarRentalManagementUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}