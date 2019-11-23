namespace CommandExecutor
{
    public class CreateUserCommand : ICommand
    {
        public long dni;
        public string name;
        public string password;
        public string username;
    }

    public class CreateUserCommandHandler : ICommandHandler<Result, CreateUserCommand>
    {
        private readonly UserCreator dependency;

        public CreateUserCommandHandler(UserCreator dependency)
        {
            this.dependency = dependency;
        }

        public Result Handle(CreateUserCommand cmd)
        {

            var result = dependency.CreateItOk(cmd.username, cmd.password);
            return result;
        }
    }

    public class UserCreator
    {
        public Result<User> CreateItOk(string username, string password)
        {
            //create it maybe?
            var usr = new User { password = password, username = username };
            return Result.SuccessWithReturnValue(usr);
        }
    }

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