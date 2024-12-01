using Xunit;
namespace SpaceBattle.Lib.Tests;

public class InjectableCommandTests
{
    [Fact]
    public void InjectableCommandTest()
    {
        var cmd = new EmptyCommand();
        var inj_cmd = new InjectableCommand();
        inj_cmd.Inject(cmd);
        inj_cmd.Execute();
    }
}
