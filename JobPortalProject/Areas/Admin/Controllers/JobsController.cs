using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobPortalProject.Data;
using JobPortalProject.Models;
using Microsoft.AspNetCore.Authorization;
using JobPortalProject.Models.Home;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace JobPortalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class JobsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public string CurrentUserId
        {
            get
            {
                return User.FindFirst(ClaimTypes.NameIdentifier).Value;
            }
        }

        public JobsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Jobs
        public async Task<IActionResult> Index()
        {
            if (User.IsInRole("Admin"))
            {
                var jobs = await _context.Jobs.ToListAsync();
                return View(jobs);
            }
            else
            {
                var jobs = await _context.Jobs
                                .Where(a => a.JobUsers.Exists(au => au.UserId == CurrentUserId))
                                .ToListAsync();

                return View(jobs);
            }
        }

        // GET: Admin/Jobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (!await HasAccessToJob(id.Value))
            {
                return View("_Error");
            }

            var job = await _context.Jobs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // GET: Admin/Jobs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Jobs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,JobName,City,Category,Description,DateIn,DateOut")] Job job)
        {
            if (ModelState.IsValid)
            {
                _context.Add(job);

                _context.JobUsers.Add(new JobUser
                {
                    UserId = CurrentUserId,
                    Job = job
                });

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(job);
        }

        // GET: Admin/Jobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (!await HasAccessToJob(id.Value))
            {
                return View("_Error");
            }

            var job = await _context.Jobs.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }

        // POST: Admin/Jobs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,JobName,City,Category,Description,DateIn,DateOut")] Job job)
        {
            if (id != job.Id)
            {
                return NotFound();
            }

            if (!await HasAccessToJob(id))
            {
                return View("_Error");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(job);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobExists(job.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(job);
        }

        // GET: Admin/Jobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (!await HasAccessToJob(id.Value))
            {
                return View("_Error");
            }

            var job = await _context.Jobs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // POST: Admin/Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!await HasAccessToJob(id))
            {
                return View("_Error");
            }

            var job = await _context.Jobs.FindAsync(id);
            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // has access to job
        private async Task<bool> HasAccessToJob(int jobId)
        {
            if (User.IsInRole("Admin"))
                return true;

            var job = await _context.Jobs
                                .Where(a => a.Id == jobId)
                                .Where(a => a.JobUsers.Exists(au => au.UserId == CurrentUserId))
                                .SingleOrDefaultAsync();

            return job != null;
        }

        private bool JobExists(int id)
        {
            return _context.Jobs.Any(e => e.Id == id);
        }
    }
}
