using Xunit;
namespace SpaceBattle.Lib.Tests;

public class MovingAdapterTests
{
    [Fact]
    public void AdapterDefaultValuesTest()
    {
        var dictionary = new Dictionary<string, object>();
        var adapter = new MovingAdapter(dictionary);

        Assert.Equal(default(Vector), adapter.Position);
        Assert.Equal(default(Vector), adapter.Velocity);
    }
}
