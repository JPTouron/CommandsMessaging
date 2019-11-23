using CommandExecutor.ClientCodeSample;
using CommandExecutor.Commands.SampleImplementations;
using FluentAssertions;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class CreateUserCommandHandlerTests
    {
        [Fact]
        public void CreateUserFailure()
        {
            var creator = new UserCreatorFail();
            var handler = new CreateUserCommandHandler(creator);

            var cmd = new CreateUserCommand { password = "p", username = "l" };

            var result = handler.Handle(cmd);

            result.IsSuccess.Should().BeFalse();
            result.ErrorMessage.Should().NotBeNullOrEmpty();
            Action action = () => { var i = result.Value; };
            action.Should().Throw<InvalidOperationException>().WithMessage("There is no value to access on a failed Result");
        }

        [Fact]
        public void CreateUserOk()
        {
            var creator = new UserCreatorOk();
            var handler = new CreateUserCommandHandler(creator);

            var cmd = new CreateUserCommand { password = "password", username = "user" };

            var result = handler.Handle(cmd);

            result.IsSuccess.Should().BeTrue();
            result.ErrorMessage.Should().BeNullOrEmpty();
            result.Value.Should().NotBeNull();
            result.Value.password.Should().Be("password");
            result.Value.username.Should().Be("user");
        }
    }
}