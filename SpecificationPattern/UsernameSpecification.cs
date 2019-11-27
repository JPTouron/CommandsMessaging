using CommandExecutor.ClientCodeSample;

namespace SpecificationPattern
{
    public class UsernameSpecification : ISpecification<User>
    {
        public bool IsSatisfiedBy(User value)
        {
            return !string.IsNullOrWhiteSpace(value.username);
        }
    }
}