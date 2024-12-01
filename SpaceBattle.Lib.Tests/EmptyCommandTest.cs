using Xunit;
namespace SpaceBattle.Lib.Tests;

public class EmptyCommandTest
{
    [Fact]
    public void Execute_EmptyCommand()
    {
        var empty_cmd = new EmptyCommand();
        empty_cmd.Execute();
    }
}

