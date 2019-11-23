using System;

namespace CommandExecutor
{
    internal class Program
    {
        private static CreateUserCommandHandler GetHandler()
        {
            return new CreateUserCommandHandler(new UserCreator());
        }

        private static void Main(string[] args)
        {
            Result user = CommandDemo();



            Console.WriteLine($"User Created {user} ");
        }

        private static Result CommandDemo()
        {
            var cmd = new CreateUserCommand { username = "JP", password = "secure!" };

            var handler = GetHandler();

            var user = handler.Handle(cmd);
            return user;
        }
    }
}