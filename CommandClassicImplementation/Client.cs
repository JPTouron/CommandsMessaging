namespace CommandClassicImplementation
{
    /// <summary>
    /// Client class, orchestrator role
    /// info: https://refactoring.guru/design-patterns/command
    /// </summary>
    public class Client
    {
        public int PerformSum(int x, int y)
        {
            var result = 0;

            var invoker = new Invoker();
            var factory = new CommandFactory();
            using (var rcvHandler = new ReceiverHandler())
            {
                rcvHandler.SubscribeClient(x => result = x);
                var rcv = rcvHandler.GetReceiver();
                var cmd = factory.GetCommand(rcv, x, y);

                invoker.SetCommand(cmd);
                invoker.ExecuteCommand();
            }

            return result;
        }
    }
}