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
        [Key]
        public int EventId { get; set; }
        public string EventTitle { get; set; }
        public string EventDesc { get; set; }
        [Required]
        public string StartDate { get; set; }
        [Required]
        public string EndDate { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public string EndTime { get; set; }
        public string Location { get; set; }

        [Required]
        public int MaxTix { get; set; }
        [Required]
        public int AvailableTix { get; set; }

        public Organizer Organizer { get; set; }
        public EventType EventType { get; set; }



        [Required]
        public string OrgName { get; set; }
        public string OrgEmail { get; set; }
        public string OrgPhone { get; set; }

    }
}