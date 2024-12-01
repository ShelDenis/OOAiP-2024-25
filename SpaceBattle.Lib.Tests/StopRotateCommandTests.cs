using Moq;
using Xunit;

namespace SpaceBattle.Lib.Tests;

public class StopRotateCommandTests
{
    [Fact]
    public void StopRotateCommandTest()
    {
        var queue = new Queue<ICommand>();

        var velocityAngle = new Angle(45);
        var positionAngle = new Angle(0);

        var gameObject = new Dictionary<string, object>();
        gameObject["PositionAngle"] = positionAngle;

        var startRotateOrder = new Mock<StartRotateOrder>();
        startRotateOrder.SetupGet(m => m.VelocityAngle).Returns(velocityAngle);
        startRotateOrder.SetupGet(m => m.GameObject).Returns(gameObject);

        var startRotateCmd = new StartRotateCommand(startRotateOrder.Object, queue);
        var stopRotateCmd = new StopRotateCommand(gameObject);

        startRotateCmd.Execute();

        queue.Dequeue().Execute();

        stopRotateCmd.Execute();
        queue.Dequeue().Execute();

        Assert.Throws<InvalidOperationException>(() => queue.Dequeue().Execute());
    }
}
