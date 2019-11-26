namespace CommandClassicImplementation
{
    public class CommandFactory
    {
        public ICommand GetCommand(Receiver rcv, int x, int y)
        {
            var cmd = new SumCommand(rcv, x, y);
            return cmd;
        }
    }
}