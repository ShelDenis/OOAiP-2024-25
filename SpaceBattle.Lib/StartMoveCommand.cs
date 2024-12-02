namespace SpaceBattle.Lib;

public class StartMoveCommand : ICommand
{
    private readonly StartMoveOrder _order;
    private readonly Queue<ICommand> _queue;
    public StartMoveCommand(StartMoveOrder order, Queue<ICommand> queue)
    {
        _order = order;
        _queue = queue;
    }
    public void Execute()
    {
        IMoving MovingGameObject = new MovingAdapter(_order.GameObject);
        _order.GameObject["Velocity"] = _order.velocity;
        var moveCommand = new MoveCommand(MovingGameObject);

        var injectable = new InjectableCommand();

        var repeat = new RepeatCommand(_queue, injectable);
        var repeatableMove = new MCommand(new List<ICommand> { moveCommand, repeat });

        injectable.Inject(repeatableMove);
        _order.GameObject["repeatableMove"] = injectable;
        _queue.Enqueue(repeatableMove);
    }
}
