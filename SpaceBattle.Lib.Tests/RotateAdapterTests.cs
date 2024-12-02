using Xunit;
namespace SpaceBattle.Lib.Tests;

public class RotateAdapterTests
{
    [Fact]
    public void AdapterDefaultValuesTest()
    {
        var dictionary = new Dictionary<string, object>();
        var adapter = new RotateAdapter(dictionary);

        Assert.Equal(default(Angle), adapter.PositionAngle);
        Assert.Equal(default(Angle), adapter.VelocityAngle);
    }
}
