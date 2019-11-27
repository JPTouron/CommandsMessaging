using CommandExecutor.Commands.BaseStructure;

namespace CommandExecutor.Commands.SampleImplementations
{
    public class CreateUserCommand : ICommand
    {
        //Remark: this should have some constructor of sorts to validate invariants and such, too lazy to do it
        public int id;
        public long dni;
        public string name;
        public string password;
        public string username;
    }
}