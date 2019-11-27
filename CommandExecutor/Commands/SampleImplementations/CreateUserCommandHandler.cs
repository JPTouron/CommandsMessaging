using CommandExecutor.ClientCodeSample;
using CommandExecutor.Commands.BaseStructure;
using CommandExecutor.Functional;
using CommandExecutor.Guards;

namespace CommandExecutor.Commands.SampleImplementations
{
    public class CreateUserCommandHandler : ICommandHandler<Result<User>, CreateUserCommand>
    {
        private readonly IUserCreator dependency;

        public CreateUserCommandHandler(IUserCreator dependency)
        {
            Guard.Against.Null(dependency, nameof(dependency));

            this.dependency = dependency;
        }

        public Result<User> Handle(CreateUserCommand cmd)
        {
            ValidateInvariants(cmd);

            var result = dependency.CreateIt(cmd.username, cmd.password);

            return result;
        }

        private static void ValidateInvariants(CreateUserCommand cmd)
        {
            Guard.Against.Null(cmd, nameof(cmd));
            Guard.Against.NullOrWhiteSpace(cmd.password, nameof(cmd.password));
            Guard.Against.NullOrWhiteSpace(cmd.username, nameof(cmd.username));
        }
    }
}