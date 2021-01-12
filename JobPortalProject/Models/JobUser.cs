using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalProject.Models
{
    public class JobUser
    {
        public int JobId { get; set; }
        public Job Job { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
