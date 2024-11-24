public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        IsCompleted = true;
        Console.WriteLine($"You earned {Points} points for completing: {Name}");
    }

    public override string GetStatus()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }

    public override string SaveToFile()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{IsCompleted}";
    }
}

