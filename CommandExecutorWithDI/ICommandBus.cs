using CommandExecutor.Commands.BaseStructure;
using CommandExecutor.Functional;

namespace CommandExecutorWithDI
{
    /// <summary>
    /// public visible face of the command bus, the implementation is private to the rest of the universe
    /// this class could be contained in its own assembly
    /// </summary>
    public interface ICommandBus
    {
        TResult SendCommand<T, TResult>(T command) where TResult : Result where T : ICommand;
    }
}