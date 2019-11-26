namespace CommandExecutor.ClientCodeSample
{
    public class User
    {
        public string password;
        public string username;

        public override string ToString()
        {
            return "name: " + username + " - pasword: " + password;
        }
    }
}