namespace CommandExecutor
{
    public class CreateUserCommand : ICommand
    {
        public long dni;
        public string name;
        public string password;
        public string username;
    }
}