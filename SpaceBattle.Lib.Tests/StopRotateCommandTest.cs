using Moq;
using Xunit;
namespace SpaceBattle.Lib.Tests;

public class StopCommandTests
{
    [Fact]
    public void StopCommandTest()
    {
        var injectableMock = new Mock<Injectable>();
        var gameObject = new Mock<IDictionary<string, object>>();

        gameObject.Setup(d => d["repeatableRotate"]).Returns(injectableMock.Object);

        var command = new StopRotateCommand(gameObject.Object);

        command.Execute();

        injectableMock.Verify(i => i.Inject(It.IsAny<EmptyCommand>()), Times.Once);
    }
}
