public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0 * 0.62; // Convert meters to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60; // Speed = distance / time * 60
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance(); // Pace = time / distance
    }
}
