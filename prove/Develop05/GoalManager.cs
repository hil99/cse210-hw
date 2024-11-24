public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalPoints = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name} ({goals[i].Description})");
        }
        Console.WriteLine($"\nYou have {totalPoints} points.");
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 1 || goalIndex > goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal goal = goals[goalIndex - 1];
        goal.RecordEvent();
        totalPoints += goal.Points;

        if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
        {
            totalPoints += checklistGoal.BonusPoints;
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.SaveToFile());
            }
            writer.WriteLine(totalPoints);
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals(string filename)
    {
        goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.StartsWith("SimpleGoal"))
                {
                    string[] parts = line.Split('|');
                    goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (line.StartsWith("EternalGoal"))
                {
                    string[] parts = line.Split('|');
                    goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (line.StartsWith("ChecklistGoal"))
                {
                    string[] parts = line.Split('|');
                    ChecklistGoal goal = new ChecklistGoal(
    parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]), 
    int.Parse(parts[4]), bool.Parse(parts[7])
);
goals.Add(goal);

                }
                else
                {
                    totalPoints = int.Parse(line);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
}
