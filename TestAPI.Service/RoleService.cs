using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;
using TestAPI.Repository;

namespace TestAPI.Service
{
    public class RoleService : IService<Role>
    {
        private IRepository<Role> _role;
        public RoleService(IRepository<Role> role)
        {
            _role = role;
        }
        public IEnumerable<Role> Get()
        {
            IEnumerable<Role> roles = _role.Get();
            return roles;
        }
    }
}
