namespace CommandExecutor.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T value);
    }
}