using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobPortalProject.Models;
using JobPortalProject.Data;
using JobPortalProject.Models.Home;
using Microsoft.EntityFrameworkCore;

namespace JobPortalProject.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: Jobs
        public async Task<IActionResult> Index(IndexViewModel viewModel)
        {
            var q = _dbContext.Jobs.AsQueryable();

            // Filter by name (Name must contain given value)
            if (!String.IsNullOrEmpty(viewModel.JobName))
            {
                q = q.Where(p => p.JobName.Contains(viewModel.JobName));
            }

            viewModel.Job = await q.ToListAsync();

            return View(viewModel);
        }

        //GET: Job Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _dbContext.Jobs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
