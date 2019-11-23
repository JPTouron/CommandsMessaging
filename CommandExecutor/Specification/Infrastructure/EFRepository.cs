using CommandExecutor.ClientCodeSample;
using CommandExecutor.Specification.Ports;
using System.Collections.Generic;
using System.Linq;

namespace CommandExecutor.Specification.Infrastructure
{
    public class EFRepository : IRepository
    {
        public List<User> users;

        public EFRepository()
        {
            users = new List<User>();

            users.Add(new User { username = "juan" });
            users.Add(new User { username = "pedro" });
            users.Add(new User { username = "pablo" });
            users.Add(new User { username = "grisi" });
        }

        public bool UserNameAlreadyExists(string userName)
        {
            //info: https://www.tutorialspoint.com/Compare-two-strings-lexicographically-in-Chash
            return users.Any(x => string.Compare(x.username, userName, true) == 0);
        }
    }
}