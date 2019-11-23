using CommandExecutor.Functional;

namespace CommandExecutor.ClientCodeSample
{
    public interface IUserCreator
    {
        Result<User> CreateIt(string username, string password);
    }
}