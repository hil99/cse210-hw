using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Activity running = new Running(new DateTime(2024, 12, 7), 30, 3.0); // 3 miles in 30 minutes
        Activity cycling = new Cycling(new DateTime(2024, 12, 8), 45, 12.0); // Speed 12 mph
        Activity swimming = new Swimming(new DateTime(2024, 12, 9), 25, 20); // 20 laps

        // Add activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
