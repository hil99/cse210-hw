using System;

public abstract class Activity
{
    private DateTime date;
    private int durationMinutes; // Activity duration in minutes

    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    public int GetDuration()
    {
        return durationMinutes;
    }

    public DateTime GetDate()
    {
        return date;
    }

    // Virtual methods for distance, speed, and pace to be overridden by derived classes
    public abstract double GetDistance(); // Distance in miles or kilometers
    public abstract double GetSpeed(); // Speed in mph or kph
    public abstract double GetPace(); // Pace in minutes per mile or per kilometer

    // Get a summary of the activity
    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({durationMinutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}
