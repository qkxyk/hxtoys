using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;
using TestAPI.Repository;

namespace TestAPI.Service
{
    public class UserService : IUserService
    {
        private IRepository<User> _user;
        private IService<Role> _role;
        public UserService(IRepository<User> user, IService<Role> role)
        {
            _user = user;
            _role = role;
        }
        //private UserRepository _user = new UserRepository();
        public IEnumerable<User> GetUser()
        {

            //IRoleService r = Container.Resolve<IRole>();
            //r.GetRoles();
            IEnumerable<Role> r = _role.Get();
            IEnumerable<User> users = _user.Get();
            return users;
        }
    }
}
