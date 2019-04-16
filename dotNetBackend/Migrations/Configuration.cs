namespace dotNetBackend.Migrations
{
    using dotNetBackend.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<dotNetBackend.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(dotNetBackend.Models.ApplicationDbContext context)
        {
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "ADMIN" };
                manager.Create(role);
            }
            if (!context.Roles.Any(r => r.Name == "PAGE_1"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "PAGE_1" };
                manager.Create(role);
            }
            if (!context.Roles.Any(r => r.Name == "PAGE_2"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "PAGE_2" };
                manager.Create(role);
            }
            if (!context.Roles.Any(r => r.Name == "PAGE_3"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "PAGE_3" };
                manager.Create(role);
            }

            if (!context.Users.Any(u => u.UserName == "admin@admin.es"))
            {
                var Password = new PasswordHasher();
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "admin@admin.es", Email = "admin@admin.es", PasswordHash = Password.HashPassword("123456@App") };
                manager.Create(user);

                manager.AddToRole(user.Id, "ADMIN");

            }
            if (!context.Users.Any(u => u.UserName == "page1@test.es"))
            {
                var Password = new PasswordHasher();
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "page1@test.es", Email = "page1@test.es", PasswordHash = Password.HashPassword("123456@App") };
                manager.Create(user);

                manager.AddToRole(user.Id, "PAGE_1");

            }

            if (!context.Users.Any(u => u.UserName == "page2@test.es"))
            {
                var Password = new PasswordHasher();
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "page2@test.es", Email = "page2@test.es", PasswordHash = Password.HashPassword("123456@App") };
                manager.Create(user);

                manager.AddToRole(user.Id, "PAGE_2");

            }

            if (!context.Users.Any(u => u.UserName == "page3@test.es"))
            {
                var Password = new PasswordHasher();
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "page3@test.es", Email = "page3@test.es", PasswordHash = Password.HashPassword("123456@App") };
                manager.Create(user);

                manager.AddToRole(user.Id, "PAGE_3");

            }
        }
    }
}
