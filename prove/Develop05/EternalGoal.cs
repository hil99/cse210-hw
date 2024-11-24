public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {Points} points for working on: {Name}");
    }

    public override string GetStatus()
    {
        return "[∞]"; // Infinite symbol to show eternal goals
    }

    public override string SaveToFile()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}
