using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage ="Location is required")]
        public string Location { get; set; }

        [Required(ErrorMessage ="Please enter a number of attendees")]
        [Range(1,100000, ErrorMessage ="more than zero, less than 100,000")]
        public int NumOfAttendees { get; set; }
    }
}
