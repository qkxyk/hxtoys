using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestAPI.Model;
using TestAPI.Repository;
using TestAPI.Service;

namespace TestAPI.WebApi.Controllers
{
    public class DefaultController : ApiController
    {
        private IUserService _user;
        public DefaultController(IUserService user)
        {
            _user = user;
        }
        //private UserService _user= new UserService(new UserRepository());
        public IEnumerable<User> Get()
        {
            IEnumerable<User> user = _user.GetUser();
            return user;
        }
    }
}
