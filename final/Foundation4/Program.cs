using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of different activities
        Activity runningActivity = new Running(new DateTime(2022, 11, 03), 30, 3.0);
        Activity cyclingActivity = new Cycling(new DateTime(2022, 11, 03), 30, 9.7);
        Activity swimmingActivity = new Swimming(new DateTime(2022, 11, 03), 30, 20);

        // Put each activity in the same list
        List<Activity> activities = new List<Activity>
        {
            runningActivity,
            cyclingActivity,
            swimmingActivity
        };

        // Display summary information for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}