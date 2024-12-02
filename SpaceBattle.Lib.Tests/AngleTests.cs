using Xunit;
namespace SpaceBattle.Lib.Tests;

public class AngleTests
{
    [Fact]
    public void Execute_Adding()
    {
        var angle1 = new Angle(270);
        var angle2 = new Angle(200);
        var resAngle = new Angle(110);
        var newAngle = angle1 + angle2;

        Assert.Equal(resAngle, newAngle);
    }

    [Fact]
    public void Execute_Equal()
    {
        var angle1 = new Angle(180);
        var angle2 = new Angle(180);

        Assert.True(angle1.Equals(angle2));
    }

    [Fact]
    public void Execute_AnglePrint()
    {
        var angle = new Angle(67);

        Assert.Equal("67 degrees", angle.ToString());
    }

    [Fact]
    public void Execute_GetDegrees()
    {
        var angle1 = new Angle(77);

        Assert.Equal(77, angle1.Degrees);
    }

    [Fact]
    public void Execute_SetDegrees()
    {
        var angle1 = new Angle(77);
        angle1.Degrees = 87;

        Assert.Equal(87, angle1.Degrees);
    }

    [Fact]
    public void Execute_GetHashCode()
    {
        var angle1 = new Angle(54);
        var angle2 = new Angle(54);

        Assert.True(angle1.GetHashCode() == angle2.GetHashCode());
    }
}
