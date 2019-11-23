using CommandExecutor.ClientCodeSample;
using CommandExecutor.Specification;
using CommandExecutor.Specification.Infrastructure;
using FluentAssertions;
using Xunit;

namespace XUnitTestProject1
{
    public class SpecificationTests
    {
        [Fact]
        public void AndSpecification_ShouldBeSatisfiedWhenBothSpecsAreTrue()
        {
            var spec1 = new UsernameSpecification();
            var spec2 = new PasswordSpecification();

            var and = new AndSpecification<User>(spec1, spec2);

            var user1 = new User { username = "juan", password = "abcdefg1" };

            and.IsSatisfiedBy(user1).Should().BeTrue();
        }

        [Fact]
        public void InfrastructureDependentSpecification_ShouldBeSatisfiedWhenUserNameIsUnique()
        {
            var repo = new EFRepository();

            var spec = new InfrastructureDependentSpecification(repo);

            var user1 = new User { username = "mleh" };

            spec.IsSatisfiedBy(user1).Should().BeTrue();

            user1.username = "pedro";
            spec.IsSatisfiedBy(user1).Should().BeFalse();

            user1.username = "juan";
            spec.IsSatisfiedBy(user1).Should().BeFalse();

            user1.username = "minga";
            spec.IsSatisfiedBy(user1).Should().BeTrue();
        }

        [Fact]
        public void OrSpecification_ShouldBeSatisfiedWhenOneOfTheSpecsIsTrue()
        {
            var spec1 = new UsernameSpecification();
            var spec2 = new PasswordSpecification();

            var or = new OrSpecification<User>(spec1, spec2);

            var user1 = new User { username = "", password = "abcdefg1" };

            or.IsSatisfiedBy(user1).Should().BeTrue();
        }

        [Fact]
        public void PasswordSpecification_ShouldBeSatisfiedWhenPasswordIs8CharsLongWithANumber()
        {
            var spec = new PasswordSpecification();

            var user = new User { password = "abcdefg1" };

            spec.IsSatisfiedBy(user).Should().BeTrue();
        }

        [Fact]
        public void UserNameSpecification_ShouldBeSatisfiedIfUserNameIsNotEmpty()
        {
            var spec = new UsernameSpecification();
            var user = new User { username = "juan" };

            spec.IsSatisfiedBy(user).Should().BeTrue();
        }
    }
}