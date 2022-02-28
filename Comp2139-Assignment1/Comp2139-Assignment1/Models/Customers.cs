using System.ComponentModel.DataAnnotations;

namespace GBCSporting_OJO.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Customer needs to have First Name" )]
        [Display(Name ="First Name")]
        public string? CustomerFirstName { get; set; }

        [Required(ErrorMessage = "Customer needs to have Last Name")]
        [Display(Name = "Last Name")]
        public string? CustomerLastName { get; set; }

        [Required(ErrorMessage = "Customer needs to have an Address")]
        [Display(Name = "Address")]
        public string? CustomerAddress { get; set; }

        [Required(ErrorMessage = "Customer needs to have a City")]
        [Display(Name = "City")]
        public string? CustomerCity { get; set; }

        [Required(ErrorMessage = "Customer needs to have a State")]
        [Display(Name = "State")]
        public string? CustomerState { get; set; }

        [Required(ErrorMessage = "Customer needs to have a Country")]
        [Display(Name = "Country")]
        public string? CustomerCountry { get; set; }

        [Display(Name = "Email")]
        public string? CustomerEmail { get; set; }

        [Display(Name = "Phone")]
        public string? CustomerPhone { get; set; }
        
    }
}
