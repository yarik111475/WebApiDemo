using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Server.Models;

namespace Server.Repositories {
    public class FakeUserRepository : IUserRepository {
        static IEnumerable<User> users;
        static FakeUserRepository() {
            users = new List<User> {
                new User{Id=1, Name="Tom", Age=24 },
                new User{Id=2, Name="Mary", Age=28 },
                new User{Id=3, Name="Anny", Age=19 }
            };
        }
        public User GetUserById(int id) {
            return users.Where(u => u.Id == id).FirstOrDefault();
        }

        public IEnumerable<User> GetUsers() {
            return users;
        }

        public IEnumerable<User> GetUsersByName(string name) {
            return users.Where(u => u.Name == name);
        }
    }
}