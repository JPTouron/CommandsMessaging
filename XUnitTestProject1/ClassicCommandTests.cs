using CommandClassicImplementation;
using FluentAssertions;
using Xunit;

namespace XUnitTestProject1
{
    public class ClassicCommandTests
    {
        [Fact]
        public void TestClient()
        {
            var cli = new Client();

            var result = cli.PerformSum(2, 3);

            result.Should().Be(5);
        }
    }
}