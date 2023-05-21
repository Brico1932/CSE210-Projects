using System;
public class EternalGoal: Goal
{
    public EternalGoal(string name, int type, string description, int pointValue, bool isDone)
        :base(name, type, description, pointValue, isDone)
        {
            type = 2;
        }
    public override void CreateGoal(List<Goal> allgoals, int type)
    {
        base.CreateGoal(allgoals,type);
        
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        string pointValuestr = Console.ReadLine();
        int pointValue = int.Parse(pointValuestr);
        bool isDone = false;
        EternalGoal newgoal = new EternalGoal(name,type, description,pointValue,isDone);
        allgoals.Add(newgoal);
    }
    public override void DisplayGoals(Goal goal, int counter)
    {
        Console.WriteLine($"{counter}. [ ] {goal.GetName()} ({goal.GetDescription()})");
    }

}
