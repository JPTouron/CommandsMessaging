namespace CommandExecutor.ClientCodeSample
{
    public class User
    {
        public int id;
        public string password;
        public string username;

        public override string ToString()
        {
            return "id: " + id + " - name: " + username + " - pasword: " + password;
        }
    }
}