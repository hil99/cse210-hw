public class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }

    public virtual void RecordEvent() { }
}

public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {Points} points for completing a task in {Name}");
    }
}
