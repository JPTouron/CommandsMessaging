namespace CommandClassicImplementation
{
    /// <summary>
    /// Busines logic stuff
    /// </summary>
    public class Receiver : INotifySumResult
    {
        private readonly IntegerSumDependency additioner;

        public Receiver(IntegerSumDependency additioner)
        {
            this.additioner = additioner;
        }

        public event INotifySumResult.SumResult CalculatedResult;
        public void Sum(int x, int y)
        {

            var result = additioner.PerformSum(x, y);
            CalculatedResult(result);
        }

    }
}
