public class Cycling : Activity
{
    private double speed; // Speed in mph

    public Cycling(DateTime date, int durationMinutes, double speed)
        : base(date, durationMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * GetDuration()) / 60; // Distance = speed * time
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed; // Pace = 60 / speed
    }
}
