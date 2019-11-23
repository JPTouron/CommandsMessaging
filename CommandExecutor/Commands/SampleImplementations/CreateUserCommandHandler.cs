
using CommandExecutor.ClientCodeSample;
using CommandExecutor.Commands.BaseStructure;
using CommandExecutor.Functional;

namespace CommandExecutor.Commands.SampleImplementations
{
    public class CreateUserCommandHandler : ICommandHandler<Result<User>, CreateUserCommand>
    {
        private readonly IUserCreator dependency;

        public CreateUserCommandHandler(IUserCreator dependency)
        {
            this.dependency = dependency;
        }

        public Result<User> Handle(CreateUserCommand cmd)
        {

            var result = dependency.CreateIt(cmd.username, cmd.password);
            return result;
        }

    }
}