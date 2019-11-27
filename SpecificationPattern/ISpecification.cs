namespace SpecificationPattern
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T value);
    }
}