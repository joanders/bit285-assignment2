namespace Assignment2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2.Models.VisitorLogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Assignment2.Models.Program";

        }

        protected override void Seed(Assignment2.Models.VisitorLogContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Users.AddOrUpdate(b => b.UserID,
                new Models.User()
                {
                    UserID = 1,
                    FirstName = "Joan",
                    LastName = "Anderson",
                    Email = "dawson.joan.m@gmail.com",
                    Password = "8dawsojo"

                });
        }
    }
}
