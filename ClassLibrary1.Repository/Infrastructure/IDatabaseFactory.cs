using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository.Infrastructure
{
   public interface IDatabaseFactory : IDisposable
    {
        EmployeeContext Get();
    }
}
