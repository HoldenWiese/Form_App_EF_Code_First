namespace CodeFirstFormsApp.Migrations
{
    using CodeFirstFormsApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstFormsApp.Data.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstFormsApp.Data.SalesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Regions.AddOrUpdate(
                p => p.Id,
                new Models.SalesRegion
                {
                    Active = true,
                    Code = "NTH",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Id = 1,
                    Name = "North Region",
                    SalesTarget = 10000.00M,
                    UpdateBy = "Admin",
                    UpdatedDate = DateTime.Now
                },
                new Models.SalesRegion
                {
                    Active = true,
                    Code = "STH",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Id = 2,
                    Name = "South Region",
                    SalesTarget = 10000.00M,
                    UpdateBy = "Admin",
                    UpdatedDate = DateTime.Now
                }
            );
            context.People.AddOrUpdate(
                p => p.Id,
                new SalesPerson
                {
                    Active = true,
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    FirstName = "Bob",
                    Id = 1,
                    LastName = "Smith",
                    RegionId = 1,
                    SalesTarget = 2000.00M,
                    UpdateBy = "Admin",
                    UpdatedDate = DateTime.Now
                }
            );
            context.Sales.AddOrUpdate(
                p => p.Id,
                new Sale
                {
                    Amount = 321.45M,
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Date = new DateTime(2020, 5, 19),
                    Id = 1,
                    PersonId = 1,
                    RegionId = 1,
                    UpdateBy = "Admin",
                    UpdatedDate = DateTime.Now
                }
            );


        }
    }
}
