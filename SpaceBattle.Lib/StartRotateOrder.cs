namespace SpaceBattle.Lib;

public interface StartRotateOrder
{
    IDictionary<string, object> GameObject { get; }
    Angle VelocityAngle { get; }
}
