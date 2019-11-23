namespace CommandExecutor.Specification.Ports
{
    public interface IRepository
    {
        bool UserNameAlreadyExists(string userName);
    }
}