using System;
public class SimpleGoal: Goal
{
    public SimpleGoal(string name, int type, string description, int pointValue, bool isDone)
    :base(name, type, description, pointValue, isDone)
    {
        type = 1;
    }
    public override void CreateGoal(List<Goal> allgoals, int type)
    {   
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        string pointValuestr = Console.ReadLine();
        int pointValue = int.Parse(pointValuestr);
        bool isDone =false;
        SimpleGoal newgoal = new SimpleGoal(name,type, description,pointValue,isDone);
        allgoals.Add(newgoal);
    }
    
    public override void CompleteGoal(Goal completedgoal)
    {
        completedgoal.SetIsDone(completedgoal);
    }
    
}