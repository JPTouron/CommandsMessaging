namespace CommandExecutor.Specification
{
    public class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> spec;

        public NotSpecification(ISpecification<T> spec)
        {
            this.spec = spec;
        }

        public bool IsSatisfiedBy(T value)
        {
            return !spec.IsSatisfiedBy(value);
        }
    }
}