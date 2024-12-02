namespace SpaceBattle.Lib;

public class MovingAdapter : IMoving
{
    private readonly IDictionary<string, object> _dictionary;

    public MovingAdapter(IDictionary<string, object> dictionary)
    {
        _dictionary = dictionary;
    }

    public Vector Position
    {
        get
        {
            if (_dictionary.TryGetValue(nameof(Position), out var value))
            {
                return (Vector)value;
            }

            return default;
        }
        set => _dictionary[nameof(Position)] = value;
    }

    public Vector Velocity
    {
        get
        {
            if (_dictionary.TryGetValue(nameof(Velocity), out var value))
            {
                return (Vector)value;
            }

            return default;
        }
    }
}
