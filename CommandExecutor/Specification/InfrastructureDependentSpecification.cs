using CommandExecutor.ClientCodeSample;
using CommandExecutor.Specification.Ports;

namespace CommandExecutor.Specification
{
    public class InfrastructureDependentSpecification : ISpecification<User>
    {
        private readonly IRepository repo;

        public InfrastructureDependentSpecification(IRepository repo)
        {
            this.repo = repo;
        }

        public bool IsSatisfiedBy(User value)
        {
            return !repo.UserNameAlreadyExists(value.username);
        }
    }
}