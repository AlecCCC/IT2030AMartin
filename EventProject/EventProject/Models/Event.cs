using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace EventProject.Models
{
    public class Event
    {
        public int EventId { get; set; }
        [StringLength(50)]
        [Display(Name ="Event Name")]
        public string EventTitle { get; set; }
        [StringLength(150)]
        [Display(Name = "Event Description")]
        public string EventDesc { get; set; }
        [Required]
        [Display(Name = "Event Start Date")]
        [RegularExpression(@"^[0-9m]{1,2}/[0-9d]{1,2}/[0-9y]{4}$", ErrorMessage = "Invalid date format.")]
        public string StartDate { get; set; }
        [Required]
        [Display(Name = "Event End Date")]
        [RegularExpression(@"^[0-9m]{1,2}/[0-9d]{1,2}/[0-9y]{4}$", ErrorMessage = "Invalid date format.")]
        public string EndDate { get; set; }
        [Required]
        [Display(Name = "Event Start Time")]
        public string StartTime { get; set; }
        [Required]
        [Display(Name = "Event End Time")]
        public string EndTime { get; set; }
        [Display(Name = "Event Location")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Max Amount of Tickets")]
        public int MaxTix { get; set; }
        [Required]
        [Display(Name = "Available Tickets")]
        public int AvailableTix { get; set; }
        public EventType EventType { get; set; }

        public  int Tickets { get; set; }



        [Required]
        [Display(Name = "Organizer's Name")]
        public string OrgName { get; set; }
        [Display(Name = "Organizer's Email")]
        public string OrgEmail { get; set; }
        [Display(Name = "Organizer's Phone Number")]
        public string OrgPhone { get; set; }

    }
}