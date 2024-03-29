﻿using CommandExecutor.Functional;
using CommandExecutor.Guards;

namespace CommandExecutor.ClientCodeSample
{
    public class UserCreatorFail : IUserCreator
    {
        public Result<User> CreateIt(string username, string password)
        {
            Guard.Against.NullOrWhiteSpace(username, nameof(username));
            Guard.Against.NullOrWhiteSpace(password, nameof(password));

            return Result.FailWithDefaultReturnValue<User>("something went horribly wrong");
        }
    }

    public class UserCreatorOk : IUserCreator
    {
        public Result<User> CreateIt(string username, string password)
        {
            Guard.Against.NullOrWhiteSpace(username, nameof(username));
            Guard.Against.NullOrWhiteSpace(password, nameof(password));

            var usr = new User { password = password, username = username };
            return Result.SuccessWithReturnValue(usr);
        }
    }
}