namespace SpaceBattle.Lib;

public class Angle
{
    private int degrees;

    public Angle(int degrees)
    {
        this.degrees = degrees % 360;
    }

    public int Degrees
    {
        get => degrees;
        set => degrees = value;
    }

    public override string ToString()
    {
        return $"{degrees} degrees";
    }

    public static Angle operator +(Angle a1, Angle a2)
    {

        var result = a1.Degrees + a2.Degrees;
        return new Angle(result);
    }

    public override bool Equals(object? obj)
    {
        return obj != null && obj is Angle angle && Degrees == angle.Degrees;
    }

    public override int GetHashCode()
    {
        return degrees.GetHashCode();
    }
}
