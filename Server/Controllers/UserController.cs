using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Server.Models;
using Server.Repositories;

namespace Server.Controllers
{
    public class UserController : ApiController
    {
        IUserRepository repository;
        public UserController() {
            repository = new FakeUserRepository();
        }

        [Route("Users/getAll")]
        public IEnumerable<User> Get() {
            return repository.GetUsers();
        }

        [Route("Users/getById/{id}")]
        public User GetUserById(int id) {
            return repository.GetUserById(id);
        }

        [Route("Users/getByName/{name}")]
        public IEnumerable<User> GetUsersByName(string name) {
            return repository.GetUsersByName(name);
        }
    }
}
