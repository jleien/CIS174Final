using System;
using System.ComponentModel.DataAnnotations;

namespace CIS174Final.Areas.TicketList.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter a sprint number.")]
        public string SprintId { get; set; }
        public Sprint? Sprint { get; set; }
        [Required(ErrorMessage = "Please enter a point value.")]
        public string pointId { get; set; }
        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; }
        public Status? Status { get; set; }

    }
}
