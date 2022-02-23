using System.ComponentModel.DataAnnotations;

namespace Comp2139_Assignment1.Models
{
    public class Technicians
    {
        [Key]
        public int TecId { get; set; }

        [Required (ErrorMessage = "Technician needs a name")]
        public string? TecName { get; set; }

        [Required(ErrorMessage = "Technician needs an email")]
        public string? TecEmail { get; set; }

        [Required(ErrorMessage = "Technician needs a phone number")]
        public string? TecPhone { get; set; }

    }
}
