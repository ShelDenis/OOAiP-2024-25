namespace SpaceBattle.Lib;

public interface StartMoveOrder
{
    IDictionary<string, object> GameObject { get; }
    Vector velocity { get; }
}
