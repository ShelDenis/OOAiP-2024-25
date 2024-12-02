using Moq;
using Xunit;
namespace SpaceBattle.Lib.Tests;

public class StopMoveCommandTests
{
    [Fact]
    public void StopMoveCommandTest()
    {
        var queue = new Queue<ICommand>();

        var velocity = new Vector(new int[] { 1, 1 }); // Вектор скорости
        var position = new Vector(new int[] { 0, 0 }); // Начальная позиция

        var gameObject = new Dictionary<string, object>();
        gameObject["Position"] = position;

        var startMoveOrder = new Mock<StartMoveOrder>();
        startMoveOrder.SetupGet(m => m.velocity).Returns(velocity);
        startMoveOrder.SetupGet(m => m.GameObject).Returns(gameObject);

        var startMoveCmd = new StartMoveCommand(startMoveOrder.Object, queue);
        var stopMoveCmd = new StopMoveCommand(gameObject);

        startMoveCmd.Execute();

        queue.Dequeue().Execute();

        stopMoveCmd.Execute();

        queue.Dequeue().Execute();

        Assert.Throws<InvalidOperationException>(() => queue.Dequeue().Execute());
    }
}
