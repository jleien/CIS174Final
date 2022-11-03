using System;
using System.ComponentModel.DataAnnotations;

namespace CIS174Final.Areas.TicketList.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [RegularExpression ("^[a-zA-Z0-9]+$",
            ErrorMessage ="The name cannot have special characters" )]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        [StringLength(50, ErrorMessage ="Please keep the description under 50 characters.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter a sprint number.")]
        public string SprintId { get; set; }
        [Range(1, 5, ErrorMessage ="please enter a number between 1 and 5")]
        public Sprint? Sprint { get; set; }
        [Required(ErrorMessage = "Please enter a point value.")]
        [Range(1, 20, ErrorMessage = "please enter a number between 1 and 20")]

        public string pointId { get; set; }
        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; }
        public Status? Status { get; set; }

    }
}
