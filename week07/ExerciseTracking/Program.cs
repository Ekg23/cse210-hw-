using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Activity run = new Running(new DateTime(2024, 11, 3), 30, 4.8);
        activities.Add(run);

        Activity cycle = new Cycling(new DateTime(2024, 11, 3), 45, 20.0);
        activities.Add(cycle);

        Activity swim = new Swimming(new DateTime(2024, 11, 3), 25, 40);
        activities.Add(swim);
        
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}