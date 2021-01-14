using JobPortalProject.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalProject.Data
{
    public class SeedData
    {
        public static void Seed(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("SimpleUser").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "SimpleUser";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }


            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }

        private static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByNameAsync("admin@localhost").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "admin@localhost";
                user.Email = "admin@localhost";
                user.OwnerName = "Admin";
                user.CompanyName = "Admin's Comp";
                user.Address = "...";

                IdentityResult result = userManager.CreateAsync(user, "Admin123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }


            if (userManager.FindByNameAsync("editor@localhost").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "editor@localhost";
                user.Email = "editor@localhost";
                user.OwnerName = "Editor";
                user.CompanyName = "Editor's Comp";
                user.Address = "...";

                IdentityResult result = userManager.CreateAsync(user, "Editor123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "SimpleUser").Wait();
                }
            }
        }
    }
}
