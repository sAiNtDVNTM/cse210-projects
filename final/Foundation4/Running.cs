public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / _lengthInMinutes) * 60;
    public override double GetPace() => 60 / GetSpeed();
}