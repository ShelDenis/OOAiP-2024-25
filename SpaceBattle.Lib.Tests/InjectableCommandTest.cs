using Moq;
using Xunit;
namespace SpaceBattle.Lib.Tests;

public class InjectableCommandTests
{
    [Fact]
    public void InjectableCommandTest()
    {
        var cmd = new Mock<ICommand>();
        var inj_cmd = new InjectableCommand();
        inj_cmd.Inject(cmd.Object);
        inj_cmd.Execute();
        cmd.Verify(x => x.Execute());
    }
}
