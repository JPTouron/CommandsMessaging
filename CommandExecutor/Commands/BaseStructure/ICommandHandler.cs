using CommandExecutor.Functional;

namespace CommandExecutor.Commands.BaseStructure
{

    public interface ICommandHandler<TResult, TCommand> where TCommand : ICommand where TResult:Result
    {
        TResult Handle(TCommand cmd);
    }
}