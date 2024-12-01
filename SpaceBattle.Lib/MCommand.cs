namespace SpaceBattle.Lib;

public class MCommand : ICommand
{
    private readonly List<ICommand> cmds;
    public MCommand(List<ICommand> cmds)
    {
        this.cmds = cmds;
    }

    public void Execute()
    {
        cmds.ForEach(c => c.Execute());
    }
}
