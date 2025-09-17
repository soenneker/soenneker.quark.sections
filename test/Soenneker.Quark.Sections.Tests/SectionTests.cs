using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Sections.Tests;

[Collection("Collection")]
public sealed class SectionTests : FixturedUnitTest
{
    public SectionTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
