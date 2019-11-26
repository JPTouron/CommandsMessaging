namespace CommandClassicImplementation
{
    /// <summary>
    /// 
    /// </summary>
    public class Invoker
    {
        ICommand cmd;
        public void ExecuteCommand()
        {
            cmd.Execute();
        }

        public void SetCommand(ICommand cmd) => this.cmd = cmd;
    }
}
