using CommandExecutor.ClientCodeSample;
using CommandExecutor.Commands.BaseStructure;
using CommandExecutor.Functional;

namespace CommandExecutorWithDI
{
    public class GetByCommandHandler : ICommandHandler<Result<User>, GetByCommand>
    {
        private readonly IUserRepo repo;

        public GetByCommandHandler(IUserRepo repo)
        {
            this.repo = repo;
        }

        public Result<User> Handle(GetByCommand cmd)
        {
            User user = null;

            if (cmd.username != "")
                user = repo.GetByUserName(cmd.username);

            if (cmd.id > 0)
                user = repo.GetById(cmd.id);

            if (user == null)
                return Result.FailWithDefaultReturnValue<User>($"No user found with: name: '{cmd.username}' or id: '{cmd.id}'");
            else
                return Result.SuccessWithReturnValue(user);
        }
    }
}