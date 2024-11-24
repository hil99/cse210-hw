public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; private set; }
    public int BonusPoints { get; set; }
    

    // Constructor to initialize goal properties
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount, bool isCompleted)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = currentCount;
        IsCompleted = isCompleted;
    }

    // Method to record progress on the checklist goal
    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++; // Increase the count when progress is made
            Console.WriteLine($"You earned {Points} points for working on: {Name}");

            // If goal is completed, give bonus points
            if (CurrentCount == TargetCount)
            {
                IsCompleted = true;
                Console.WriteLine($"Congratulations! You completed {Name} and earned a bonus of {BonusPoints} points!");
            }
        }
        else
        {
            // If already completed, remind the user that bonus has been earned
            if (IsCompleted)
            {
                Console.WriteLine($"You have already completed {Name} and received the bonus points!");
            }
        }
    }

    // Method to get the status of the checklist goal
    public override string GetStatus()
    {
        return IsCompleted
            ? $"[X] Completed {CurrentCount}/{TargetCount}"
            : $"[ ] Completed {CurrentCount}/{TargetCount}";
    }

    // Method to save the goal to a file
    public override string SaveToFile()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{CurrentCount}|{TargetCount}|{BonusPoints}|{IsCompleted}";
    }
}
