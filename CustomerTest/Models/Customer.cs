using System.ComponentModel.DataAnnotations;

namespace CustomerTest.Models
{
    public class Customer
    {
        [Required]
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

    }
}
