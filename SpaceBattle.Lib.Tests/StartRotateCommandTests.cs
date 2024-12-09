using Moq;
using Xunit;
namespace SpaceBattle.Lib.Tests;

public class StartRotateCommandTests
{
    [Fact]
    public void StartRotateCommandTest()
    {
        var queue = new Queue<ICommand>();

        var velocityAngle = new Angle(45);
        var positionAngle = new Angle(0);
        var targetPositionAngle = new Angle(90);

        var gameObject = new Dictionary<string, object>();
        gameObject["PositionAngle"] = positionAngle;

        var startRotateOrder = new Mock<StartRotateOrder>();
        startRotateOrder.SetupGet(m => m.VelocityAngle).Returns(velocityAngle);
        startRotateOrder.SetupGet(m => m.GameObject).Returns(gameObject);

        var startRotateCmd = new StartRotateCommand(startRotateOrder.Object, queue);

        startRotateCmd.Execute();

        queue.Dequeue().Execute();
        queue.Dequeue().Execute();

        Assert.Equal(targetPositionAngle, gameObject["PositionAngle"]);
    }
}
