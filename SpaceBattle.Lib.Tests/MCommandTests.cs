using Moq;
using Xunit;
namespace SpaceBattle.Lib.Tests;

public class MCommandTests
{
    [Fact]
    public void MCommandTest()
    {
        var cmd1 = new Mock<ICommand>();
        var cmd2 = new Mock<ICommand>();
        List<ICommand> lst = [cmd1.Object, cmd2.Object];
        var mc = new MCommand(lst);
        mc.Execute();

        cmd1.Verify(x => x.Execute());
        cmd2.Verify(x => x.Execute());
    }
}
