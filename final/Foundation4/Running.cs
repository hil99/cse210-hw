public class Running : Activity
{
    private double distance; // Distance in miles

    public Running(DateTime date, int durationMinutes, double distance)
        : base(date, durationMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / GetDuration()) * 60; // Speed = distance / time * 60
    }

    public override double GetPace()
    {
        return GetDuration() / distance; // Pace = time / distance
    }
}
