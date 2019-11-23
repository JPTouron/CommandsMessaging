using CommandExecutor.Functional;

namespace CommandExecutor.ClientCodeSample
{
    public class UserCreatorOk : IUserCreator
    {
        public Result<User> CreateIt(string username, string password)
        {
            //create it maybe?
            var usr = new User { password = password, username = username };
            return Result.SuccessWithReturnValue(usr);
        }
    }

    public class UserCreatorFail : IUserCreator
    {
        public Result<User> CreateIt(string username, string password)
        {
            return Result.FailWithDefaultReturnValue<User>("something went horribly wrong");
        }
    }
}