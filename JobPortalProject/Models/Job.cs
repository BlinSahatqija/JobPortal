using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalProject.Models
{
    public class Job
    {
        public int Id { get; set; }

        [Required]
        public string JobName { get; set; }
        [Required]
        public City City { get; set; }
        [Required]
        public Category Category { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime DateIn { get; set; }
        [Required]
        public DateTime DateOut { get; set; }

        public List<JobUser> JobUsers { get; set; }
    }
}
