namespace ClassLibrary1.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClassLibrary1.Repository.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ClassLibrary1.Repository.EmployeeContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.State.AddOrUpdate(
                           p => p.StateId, new Entity.State1 { StateId = 1, State = "Uttarakhand" },
                                           new Entity.State1 { StateId = 2, State = "Maharashtra" }
                           );
            context.City.AddOrUpdate(
                p => p.CityId, new Entity.City { CityId = 1, StateId = 1, CityName = "Khatima" },
                               new Entity.City { CityId = 2, StateId = 1, CityName = "Nainital" },
                               new Entity.City { CityId = 3, StateId = 1, CityName = "Bhimtal" },
                               new Entity.City { CityId = 4, StateId = 1, CityName = "Pithoragarh" },
                               new Entity.City { CityId = 5, StateId = 1, CityName = "Dehradun" },
                               new Entity.City { CityId = 6, StateId = 2, CityName = "Mumbai" },
                               new Entity.City { CityId = 6, StateId = 2, CityName = "Pune" },
                               new Entity.City { CityId = 6, StateId = 2, CityName = "Nagpur" },
                               new Entity.City { CityId = 6, StateId = 2, CityName = "Amravathi" }
                );
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
