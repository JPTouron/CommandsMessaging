namespace CommandExecutor.Specification
{
    public class OrSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> left;
        private readonly ISpecification<T> right;

        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
        }
        public bool IsSatisfiedBy(T value)
        {
            return right.IsSatisfiedBy(value) || left.IsSatisfiedBy(value);
        }
    }
}