using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalProject.Models.Home
{
    public class IndexViewModel
    {
        public IEnumerable<Job> Job { get; set; }

        // Filters
        public string JobName { get; set; }
    }
}
