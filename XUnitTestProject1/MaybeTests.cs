using CommandExecutor.Functional;
using FluentAssertions;
using Xunit;

namespace XUnitTestProject1
{
    public class MaybeTests
    {
        [Fact]
        public void GetValueFromMaybeUsingTheExtensionInTests()
        {
            var m = Maybe<int>.From(15);

            m.GetValueOrDefault(4).Should().Be(15);
            m.Value().Should().Be(15);

            var m1 = Maybe<int?>.From(null);

            m1.GetValueOrDefault(4).Should().Be(4);
            m1.Value().Should().Be(0);

            var m2 = Maybe<string>.From(null);

            m2.GetValueOrDefault("hola").Should().Be("hola");
            m2.Value().Should().Be("Default Value");

            var m3 = Maybe<string>.From("pedro");

            m3.GetValueOrDefault("hola").Should().Be("pedro");
            m3.Value().Should().Be("pedro");
        }
    }
}