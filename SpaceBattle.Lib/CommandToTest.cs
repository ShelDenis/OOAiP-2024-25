namespace SpaceBattle.Lib;

public class CommandToTest : ICommand
{
    private int cnt;

    public void Execute()
    {
        cnt++;
    }

    public int getCount()
    {
        return cnt;
    }
}
