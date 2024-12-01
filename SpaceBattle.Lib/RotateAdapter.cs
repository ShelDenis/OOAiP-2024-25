namespace SpaceBattle.Lib;

public class RotateAdapter : IRotate
{
    private readonly IDictionary<string, object> _dictionary;

    public RotateAdapter(IDictionary<string, object> dictionary)
    {
        _dictionary = dictionary;
    }

    public Angle PositionAngle
    {
        get
        {
            if (_dictionary.TryGetValue(nameof(PositionAngle), out var value))
            {
                return (Angle)value;
            }

            return default;
        }
        set => _dictionary[nameof(PositionAngle)] = value;
    }

    public Angle VelocityAngle
    {
        get
        {
            if (_dictionary.TryGetValue(nameof(VelocityAngle), out var value))
            {
                return (Angle)value;
            }

            return default;
        }
    }
}
