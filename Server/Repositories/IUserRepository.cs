using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Server.Models;

namespace Server.Repositories {
    public interface IUserRepository {
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsersByName(string name);
        User GetUserById(int id);
    }
}
