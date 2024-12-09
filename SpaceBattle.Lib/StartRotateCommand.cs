namespace SpaceBattle.Lib;

public class StartRotateCommand : ICommand
{
    private readonly StartRotateOrder _order;
    private readonly Queue<ICommand> _queue;
    public StartRotateCommand(StartRotateOrder order, Queue<ICommand> queue)
    {
        _order = order;
        _queue = queue;
    }
    public void Execute()
    {
        IRotate RotateGameObject = new RotateAdapter(_order.GameObject);
        _order.GameObject["VelocityAngle"] = _order.VelocityAngle;
        var rotateCommand = new RotateCommand(RotateGameObject);

        var injectable = new InjectableCommand();

        var repeat = new RepeatCommand(_queue, injectable);
        var repeatableRotate = new MCommand(new List<ICommand> { rotateCommand, repeat });

        injectable.Inject(repeatableRotate);
        _order.GameObject["repeatableRotate"] = injectable;
        _queue.Enqueue(repeatableRotate);
    }
}
