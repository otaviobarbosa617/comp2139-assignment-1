using System.ComponentModel.DataAnnotations;

namespace Comp2139_Assignment1.Models
{
    public class Incident
    {
        [Key]
        public int IncidentId { get; set; }

        [Required (ErrorMessage = "Incident needs a customer")]
        public Customers? Customer { get; set; }

        [Required(ErrorMessage = "Incident needs a product")]
        public Products? Product { get; set; }

        [Required(ErrorMessage = "Incident needs a title")]
        public string? IncidentTitle { get; set; }

        [Required(ErrorMessage = "Incident needs a description")]
        public string? IncidentDescription { get; set; }

        public Technicians? Technician { get; set; }

        public DateTime IncidentDateOpened { get; set; }

        public DateTime? IncidentDateClosed { get; set; }

        public Incident()
        {
            this.IncidentDateOpened = DateTime.Now;
        }

    }
}
