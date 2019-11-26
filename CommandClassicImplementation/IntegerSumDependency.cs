namespace CommandClassicImplementation
{
    /// <summary>
    /// Some dependency to work with
    /// </summary>
    public class IntegerSumDependency
    {
        public int PerformSum(int x, int y)
        {
            var result = x + y;
            return result;
        }
    }
}
