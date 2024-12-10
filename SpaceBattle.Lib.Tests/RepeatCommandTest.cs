using Xunit;
namespace SpaceBattle.Lib.Tests;

public class RepeatCommandTests
{
    [Fact]
    public void RepeatCommandTest()
    {
        var queue = new Queue<ICommand>();
        var cmd = new EmptyCommand();
        var repeat_cmd = new RepeatCommand(queue, cmd);
        repeat_cmd.Execute();
        Assert.Equal(cmd, queue.Dequeue());
    }
}
