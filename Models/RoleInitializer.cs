using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomIdentityApp.Models;
using Microsoft.AspNetCore.Identity;

namespace CustomIdentityApp.Models
{
    public class RoleInitializer
    {
        public static void InitializeAsync(UserManager<User> userManager)
        {
            string adminEmail = "admin";
            string password = "_Aa123456";

            if (userManager.FindByNameAsync(adminEmail).Result == null)
            {
                User admin = new User { UserName = adminEmail, Id = "0" };
                IdentityResult result = userManager.CreateAsync(admin, password).Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }
    }
}
