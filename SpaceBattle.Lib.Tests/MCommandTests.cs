using Xunit;
namespace SpaceBattle.Lib.Tests;

public class MCommandTests
{
    [Fact]
    public void MCommandTest()
    {
        var ctt1 = new CommandToTest();
        var ctt2 = new CommandToTest();
        List<ICommand> lst = [ctt1, ctt2];
        var mc = new MCommand(lst);
        mc.Execute();

        Assert.Equal(2, ctt1.getCount() + ctt2.getCount());
    }
}
