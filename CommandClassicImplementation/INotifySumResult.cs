namespace CommandClassicImplementation
{
    /// <summary>
    /// interface for client
    /// </summary>
    public interface INotifySumResult
    {

        delegate void SumResult(int result);
        /// <summary>
        /// domain event
        /// </summary>
        event SumResult CalculatedResult;

    }
}
