namespace CommandExecutor
{
    public interface ICommand
    {
    }

    public interface ICommandHandler<TResult, TCommand> where TCommand : ICommand where TResult:Result
    {
        TResult Handle(TCommand cmd);
    }
}