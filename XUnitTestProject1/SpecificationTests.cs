using CommandExecutor.ClientCodeSample;
using CommandExecutor.Specification;
using FluentAssertions;
using Xunit;

namespace XUnitTestProject1
{
    public class SpecificationTests
    {
        [Fact]
        public void PasswordSpecification_ShouldBeSatisfiedWhenPasswordIs8CharsLongWithANumber()
        {
            var spec = new PasswordSpecification();

            var user = new User { password = "abcdefg1" };

            spec.IsSatisfiedBy(user.password).Should().BeTrue();
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