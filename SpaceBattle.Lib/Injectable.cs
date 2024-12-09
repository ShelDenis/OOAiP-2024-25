namespace SpaceBattle.Lib;

public interface Injectable
{
    void Inject(ICommand cmd);
}

public class InjectableCommand : ICommand, Injectable
{
    private ICommand _cmd = new EmptyCommand();
    public void Execute()
    {
        _cmd.Execute();
    }
    public void Inject(ICommand cmd)
    {
        _cmd = cmd;
    }
}
