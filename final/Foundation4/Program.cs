using System;

class Program
{
    static void Main(string[] args)
    {
        Swimming swim1 = new Swimming("5/30/23", 18, "Swim", 5);
        Running run2 = new Running("6/18/23", 30, "Run", 2);
        Cycling cycle3 = new Cycling("8/17/24", 60, "Cycle", 30);

        List<Activity> activities = new List<Activity>(){swim1, run2, cycle3};
        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary(activity)}");
            Console.WriteLine("");
        }
    }
}