using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventProject.Models
{
    public class EventType
    {
        [Key]
        [StringLength(50)]
        [Display(Name = "Event Type")]
        public string Type { get; set; }
    }
}