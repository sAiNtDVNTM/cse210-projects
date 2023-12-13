public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000.0;
    public override double GetSpeed() => (_laps * 50 / 1000.0) / (_lengthInMinutes / 60.0);
    public override double GetPace() => 60 / GetSpeed();
}