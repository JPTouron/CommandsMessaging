using CommandExecutor.ClientCodeSample;
using CommandExecutor.Guards;
using System.Linq;

namespace CommandExecutor.Specification
{
    public class PasswordSpecification : ISpecification<string>
    {
        public bool IsSatisfiedBy(string value)
        {
            Guard.Against.Null(value, nameof(value));

            var isLenghtOk = value.Length >= 8;
            var containsNumber = value.Any(char.IsDigit);

            return isLenghtOk && containsNumber;
        }
    }

    public class UsernameSpecification : ISpecification<User>
    {
        public bool IsSatisfiedBy(User value)
        {
            return !string.IsNullOrWhiteSpace(value.username);
        }
    }
}