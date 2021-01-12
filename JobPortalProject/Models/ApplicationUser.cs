using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string OwnerName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
    }
}
