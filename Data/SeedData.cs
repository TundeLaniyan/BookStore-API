using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Data
{
    public static class SeedData
    {
        public async static Task Seed(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await SeedRoles(roleManager);
            await SeedUsers(userManager);
        }
        private async static Task SeedUsers(UserManager<IdentityUser> userManager)
        {
            if(await userManager.FindByEmailAsync("admin@bookstore.com") == null)
            {
                var user = new IdentityUser { UserName = "admin", Email = "admin@bookstore.com" };
                var result = await userManager.CreateAsync(user, "P@ssword1");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Administrator");
                }
            }
            if (await userManager.FindByEmailAsync("admin0@bookstore.com") == null)
            {
                var user = new IdentityUser { UserName = "admin0@bookstore.com", Email = "admin0@bookstore.com" };
                var result = await userManager.CreateAsync(user, "P@ssword1");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Administrator");
                }
            }
            if (await userManager.FindByEmailAsync("customer@bookstore.com") == null)
            {
                var user = new IdentityUser { UserName = "customer@bookstore.com", Email = "customer@bookstore.com" };
                var result = await userManager.CreateAsync(user, "P@ssword1");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Customer");
                }
            }
            if (await userManager.FindByEmailAsync("customer1@bookstore.com") == null)
            {
                var user = new IdentityUser { UserName = "customer1", Email = "customer1@bookstore.com" };
                var result = await userManager.CreateAsync(user, "P@ssword1");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Customer");
                }
            }
            if (await userManager.FindByEmailAsync("customer2@bookstore.com") == null)
            {
                var user = new IdentityUser { UserName = "customer2", Email = "customer2@bookstore.com" };
                var result = await userManager.CreateAsync(user, "P@ssword1");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Customer");
                }
            }
        }

        private async static Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if(!await roleManager.RoleExistsAsync("Administrator"))
            {
                var role = new IdentityRole { Name = "Administrator" };
                await roleManager.CreateAsync(role);
            }
            if (!await roleManager.RoleExistsAsync("Customer"))
            {
                var role = new IdentityRole { Name = "Customer" };
                await roleManager.CreateAsync(role);
            }
        }
    }
}
