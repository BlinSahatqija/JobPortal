using System;
using System.Collections.Generic;
using System.Text;
using JobPortalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobPortalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobUser> JobUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<JobUser>()
            .HasKey(t => new { t.JobId, t.UserId });

            modelBuilder.Entity<JobUser>()
                .HasOne(pt => pt.Job)
                .WithMany(a => a.JobUsers)
                .HasForeignKey(pt => pt.JobId);

            modelBuilder.Entity<JobUser>()
                .HasOne(pt => pt.User)
                .WithMany()
                .HasForeignKey(pt => pt.UserId);

            #region Job Seeding
            modelBuilder.Entity<Job>().HasData(new Job
            {
                Id = 123,
                JobName = "MSSQL Expert",
                City = City.Prishtine,
                Category = Category.Database,
                Description = "Show us what you've got by sending your CV or your projects in our email. We offer a good pay. For more, contact us on 0123456789.",
                DateIn = DateTime.Now
            });

            modelBuilder.Entity<Job>().HasData(new Job
            {
                Id = 124,
                JobName = "Angular Internship",
                City = City.Prizren,
                Category = Category.Database,
                Description = "We are looking for a person who wants to expand their knowledge and is passionate about coding",
                DateIn = DateTime.Now
            });
            #endregion
        }
    }
}
