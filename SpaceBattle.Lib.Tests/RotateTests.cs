using Moq;
using Xunit;

namespace SpaceBattle.Lib.Tests;

public class RotateCommandTests
{

    [Fact]
    public void RotateCommandPositive()
    {
        var angle1 = new Angle(30);
        var angle2 = new Angle(60);

        var mockRotating = new Mock<IRotate>();
        mockRotating.SetupGet(v => v.PositionAngle).Returns(angle1).Verifiable();
        mockRotating.SetupGet(v => v.VelocityAngle).Returns(angle2).Verifiable();

        ICommand command = new RotateCommand(mockRotating.Object);
        command.Execute();

        mockRotating.VerifySet(v => v.PositionAngle = angle1 + angle2, Times.Once);
    }
}
