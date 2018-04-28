using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;

namespace TestAPI.Repository
{
    public class UserRepository : IRepository<User>
    {
        public IEnumerable<User> Get()
        {
            List<User> list = new List<User>()
            {
                new User { Id=Guid.NewGuid().ToString("N"), Name="xzc", Sex=1, Email="xxx@xxx.com", Address="aaa" }
            };
            return list;
        }
    }
}
