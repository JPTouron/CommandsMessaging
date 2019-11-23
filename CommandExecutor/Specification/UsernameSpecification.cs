using CommandExecutor.ClientCodeSample;

namespace CommandExecutor.Specification
{
    public class UsernameSpecification : ISpecification<User>
    {
        public bool IsSatisfiedBy(User value)
        {
            return !string.IsNullOrWhiteSpace(value.username);
        }
    }
}