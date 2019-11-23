namespace CommandExecutor
{
    public class UserCreator
    {
        public Result<User> CreateItOk(string username, string password)
        {
            //create it maybe?
            var usr = new User { password = password, username = username };
            return Result.SuccessWithReturnValue(usr);
        }
    }
}