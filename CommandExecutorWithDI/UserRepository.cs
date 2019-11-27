using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandExecutor.ClientCodeSample;

namespace CommandExecutorWithDI
{

    public class UserRepository : IUserRepo
    {
        List<User> users = new List<User>();
        public UserRepository()
        {
            users.Add(new User { username = "juan", id = 1 });
            users.Add(new User { username = "pedro", id = 2 });
            users.Add(new User { username = "pablo", id = 3 });
            users.Add(new User { username = "zeppelin", id = 4 });
        }

        public User GetById(int id)
        {
            return users.FirstOrDefault(x => x.id == id);
        }

        public User GetByUserName(string username)
        {

            return users.FirstOrDefault(x => x.username == username);

        }
    }
}
