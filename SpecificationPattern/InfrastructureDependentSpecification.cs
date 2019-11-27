using CommandExecutor.ClientCodeSample;
using SpecificationPattern.Ports;

namespace SpecificationPattern
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