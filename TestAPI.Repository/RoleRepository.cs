using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;

namespace TestAPI.Repository
{
    public class RoleRepository : IRepository<Role>
    {
        public IEnumerable<Role> Get()
        {
            List<Role> list = new List<Role>()
            {
                new Role { Id=Guid.NewGuid().ToString("N"), IsAdmin=true, Name="Admin" }
            };
            return list;
        }
    }
}
