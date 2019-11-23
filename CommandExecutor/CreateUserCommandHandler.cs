namespace CommandExecutor
{
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
}