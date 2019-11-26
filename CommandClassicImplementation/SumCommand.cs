namespace CommandClassicImplementation
{
    public class SumCommand : ICommand
    {
        private readonly Receiver rcv;
        private readonly int x;
        private readonly int y;

        public SumCommand(Receiver rcv, int x, int y)
        {
            this.rcv = rcv;
            this.x = x;
            this.y = y;
        }

        public void Execute()
        {
            rcv.Sum(x, y);
        }
    }
}