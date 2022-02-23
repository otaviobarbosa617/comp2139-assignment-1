using System.ComponentModel.DataAnnotations;

namespace Comp2139_Assignment1.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Customer needs to have First Name" )]
        public string? CustomerFirstName { get; set; }

        [Required(ErrorMessage = "Customer needs to have Last Name")]
        public string? CustomerLastName { get; set; }

        [Required(ErrorMessage = "Customer needs to have an Address")]
        public string? CustomerAddress { get; set; }

        [Required(ErrorMessage = "Customer needs to have a city")]
        public string? CustomerCity { get; set; }

        [Required(ErrorMessage = "Customer needs to have a State")]
        public string? CustomerState { get; set; }

        //TODO Country choice

        public string? CustomerEmail { get; set; }

        public string? CustomerPhone { get; set; }
        
    }
}
