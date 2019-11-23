using CommandExecutor.Commands.BaseStructure;

namespace CommandExecutor.Commands.SampleImplementations
{
    public class CreateUserCommand : ICommand
    {
        public long dni;
        public string name;
        public string password;
        public string username;
    }
}