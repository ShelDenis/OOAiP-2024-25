using Moq;
using Xunit;
namespace SpaceBattle.Lib.Tests;

public class StartMoveCommandTests
{
    [Fact]
    public void StartMoveCommandTest()
    {
        var queue = new Queue<ICommand>();

        var velocity = new Vector(new int[] { 1, 1 });
        var position = new Vector(new int[] { 0, 0 });
        var targetPosition = new Vector(new int[] { 2, 2 });

        var gameObject = new Dictionary<string, object>();
        gameObject["Position"] = position;

        var startMoveOrder = new Mock<StartMoveOrder>();
        startMoveOrder.SetupGet(m => m.velocity).Returns(velocity);
        startMoveOrder.SetupGet(m => m.GameObject).Returns(gameObject);

        var startMoveCmd = new StartMoveCommand(startMoveOrder.Object, queue);

        startMoveCmd.Execute();

        queue.Dequeue().Execute();
        queue.Dequeue().Execute();

        Assert.Equal(targetPosition, gameObject["Position"]);
    }
}
