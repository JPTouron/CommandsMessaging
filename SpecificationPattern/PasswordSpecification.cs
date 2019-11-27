using CommandExecutor.ClientCodeSample;
using CommandExecutor.Guards;
using System.Linq;

namespace SpecificationPattern
{
    public class PasswordSpecification : ISpecification<User>
    {
        public bool IsSatisfiedBy(User value)
        {
            Guard.Against.Null(value, nameof(value));
            Guard.Against.Null(value.password, nameof(value.password));

            var isLenghtOk = value.password.Length >= 8;
            var containsNumber = value.password.Any(char.IsDigit);

            return isLenghtOk && containsNumber;
        }
    }
}