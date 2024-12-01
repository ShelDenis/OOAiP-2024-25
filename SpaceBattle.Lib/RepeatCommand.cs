namespace SpaceBattle.Lib;

public class RepeatCommand : ICommand
{
    private readonly Queue<ICommand> _q;
    private readonly ICommand _toRepeat;
    public RepeatCommand(Queue<ICommand> q, ICommand toRepeat)
    {
        _q = q;
        _toRepeat = toRepeat;
    }

    public void Execute()
    {
        _q.Enqueue(_toRepeat);
    }
}
