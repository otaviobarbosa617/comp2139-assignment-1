using System.ComponentModel.DataAnnotations;

namespace GBCSporting_OJO.Models
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
