using ClassLibrary1.Repository.Entity;
using ClassLibrary1.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository.Repository
{
   public class EmployeeRepository : RepositoryBase<Employee2>, IEmployeeRepository
    {
        public EmployeeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }

  public interface IEmployeeRepository : IRepository<Employee2>
    {
    }
}
