using CommandExecutor.ClientCodeSample;

namespace CommandExecutorWithDI
{
    public interface IUserRepo
    {
        User GetByUserName(string username);
        User GetById(int id);
    }
}