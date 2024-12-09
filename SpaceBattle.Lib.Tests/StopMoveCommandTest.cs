using Moq;
using Xunit;

namespace SpaceBattle.Lib.Tests
{
    public class StopMoveCommandTests
    {
        [Fact]
        public void StopMoveCommandTest()
        {
            var injectableMock = new Mock<Injectable>();

            var gameObject = new Mock<IDictionary<string, object>>();

            gameObject.Setup(d => d["repeatableMove"]).Returns(injectableMock.Object);

            var command = new StopMoveCommand(gameObject.Object);

            command.Execute();

            injectableMock.Verify(i => i.Inject(It.IsAny<EmptyCommand>()), Times.Once);
        }
    }
}
