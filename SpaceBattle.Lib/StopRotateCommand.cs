namespace SpaceBattle.Lib;

public class StopRotateCommand : ICommand
{
    private readonly IDictionary<string, object> _gameObject;
    public StopRotateCommand(IDictionary<string, object> gameObject)
    {
        _gameObject = gameObject;
    }
    public void Execute()
    {
        var injectable = (Injectable)_gameObject["repeatableRotate"];
        injectable.Inject(new EmptyCommand());
    }
}
