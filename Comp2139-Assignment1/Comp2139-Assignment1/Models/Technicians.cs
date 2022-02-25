using System.ComponentModel.DataAnnotations;

namespace Comp2139_Assignment1.Models
{
    public class Technicians
    {
        [Key]
        public int TechnicianId { get; set; }

        [Required (ErrorMessage = "Technician needs a name")]
        public string? TechnicianName { get; set; }

        [Required(ErrorMessage = "Technician needs an email")]
        public string? TechnicianEmail { get; set; }

        [Required(ErrorMessage = "Technician needs a phone number")]
        public string? TechnicianPhone { get; set; }

    }
}
