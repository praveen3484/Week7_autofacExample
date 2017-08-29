using ClassLibrary1.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
   public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("ExampleConnectionString")
        {

        }
        public DbSet<Employee2> Employees { get; set; }
        public DbSet<State1> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Image> Image { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
