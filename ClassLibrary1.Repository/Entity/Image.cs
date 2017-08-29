using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository.Entity
{
   public class Image
    {
        public int id { get; set; }
        public string image { get; set; }
    }
}
//context.State.AddOrUpdate(
//               p => p.StateId, new Entity.State1 { StateId = 1, State = "Uttarakhand" },
//                               new Entity.State1 { StateId = 2, State = "Maharashtra" }
//               );
//            context.City.AddOrUpdate(int a=1;
//                p => p.CityId, new Entity.City { CityId = 1, StateId = 1, CityName = "Khatima" },
//                               new Entity.City { CityId = 2, StateId = 1, CityName = "Nainital" },
//                               new Entity.City { CityId = 3, StateId = 1, CityName = "Bhimtal" },
//                               new Entity.City { CityId = 4, StateId = 1, CityName = "Pithoragarh" },
//                               new Entity.City { CityId = 5, StateId = 1, CityName = "Dehradun" },
//                               new Entity.City { CityId = 6, StateId = 2, CityName = "Mumbai" },
//                               new Entity.City { CityId = 6, StateId = 2, CityName = "Pune" },
//                               new Entity.City { CityId = 6, StateId = 2, CityName = "Nagpur" },
//                               new Entity.City { CityId = 6, StateId = 2, CityName = "Amravathi" }
//                );