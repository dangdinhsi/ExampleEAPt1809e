namespace Example_wcf_t1809e.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Example_wcf_t1809e.Data.Example_wcf_t1809eContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Example_wcf_t1809e.Data.Example_wcf_t1809eContext context)
        {

            context.Customers.AddOrUpdate(x => x.Code, new Models.Customer()
            {
                Code ="d00474",
                Name="Dang Dinh Si",
                SecurityCode="siddd00474",
                CurrentMoney = 20000,
                Status = Models.Customer.CustomerStatus.active
            },
             new Models.Customer()
             {
                 Code = "n201090",
                 Name = "Nguyen Thanh Ngoc",
                 SecurityCode = "ngoc201090",
                 CurrentMoney = 12000,
                 Status = Models.Customer.CustomerStatus.active
             });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
