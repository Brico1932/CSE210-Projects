using System;
public class ChecklistGoal: Goal
{
    protected int _timesNeededToReachBonus;
    protected int _timesCompleted;
    protected int _bonusPointValue;
    public ChecklistGoal(string name, int type, string description, int pointValue,bool isDone, int timesNeededToReachBonus, int timesCompleted, int bonusPointValue)
        :base(name, type, description, pointValue, isDone)
        {
            type = 3;
            _timesNeededToReachBonus = timesNeededToReachBonus;
            _timesCompleted = timesCompleted;
            _bonusPointValue = bonusPointValue;
        }
        public int GetTimesNeededToReachBonus()
        {
            return _timesNeededToReachBonus;
        }
        public int GetTimesCompleted()
        {
            return _timesCompleted;
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

        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        string timesNeededToReachBonusstr = Console.ReadLine();
        int timesNeededToReachBonus = int.Parse(timesNeededToReachBonusstr);

        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        string bonusPointValuestr = Console.ReadLine();
        int bonusPointValue = int.Parse(bonusPointValuestr);
        int timesCompleted = 0;
        ChecklistGoal newgoal = new ChecklistGoal(name,type, description,pointValue,isDone,timesNeededToReachBonus,timesCompleted,bonusPointValue);
        allgoals.Add(newgoal);
    }
    public override void DisplayGoals(Goal goal, int counter)
    {
        bool isDone = GetIsDone(goal);
        if (isDone == false)
        {
            Console.WriteLine($"{counter}. [ ] {goal.GetName()} ({goal.GetDescription()})--Currently completed: {_timesCompleted}/{_timesNeededToReachBonus}");
        }
        else
        {
            Console.WriteLine($"{counter}. [X] {goal.GetName()} ({goal.GetDescription()})--Currently completed: {_timesCompleted}/{_timesNeededToReachBonus}");
        }

    }
    public override void CompleteGoal(Goal completedgoal)
    {
        _timesCompleted++;
        if (_timesCompleted == _timesNeededToReachBonus)
        {
            completedgoal.SetIsDone(completedgoal);
        }
    }
    public override int PointsToTotal(Goal completedgoal)
    {
        int pointstoadd = completedgoal.GetPointValue();
        if (_timesCompleted == _timesNeededToReachBonus)
        {
            pointstoadd = pointstoadd + _bonusPointValue;
        }

        return pointstoadd;
    }

    public override void LoadGoals(List<Goal> allgoals,string file_name)
    {
        string[] lines = File.ReadAllLines(file_name);
        
        foreach(string line in lines)
        {
            var goal= line.Split(";");
            string name = goal[0];
            string typestr = goal[1];
            int type = int.Parse(typestr);
            string description = goal[2];
            string pointValuestr = goal[3];
            int pointValue = int.Parse(pointValuestr);
            string isdonestr = goal[4];
            bool isdone = bool.Parse(isdonestr);

            string timesNeededToReachBonusstr= goal[5];
            int timesNeededToReachBonus = int.Parse(timesNeededToReachBonusstr);
            string timesCompletedstr = goal[6];
            int timesCompleted = int.Parse(timesCompletedstr);
            string bonusPointValuestr = goal[7];
            int bonusPointValue = int.Parse(bonusPointValuestr);

            ChecklistGoal newgoal = new ChecklistGoal(name,type,description,pointValue,isdone,timesNeededToReachBonus,timesCompleted,bonusPointValue);
            allgoals.Add(newgoal);
        }
    }

    public override void SaveGoals(List<Goal> allgoals, string file_name)
    {
        foreach(Goal goal in allgoals)
        {
            string path = file_name;
            using (StreamWriter outputFile = File.AppendText(path))
            {
                outputFile.Write($"{goal.GetName};");
                outputFile.Write($"{goal.GetType};");
                outputFile.Write($"{goal.GetDescription};");
                outputFile.Write($"{goal.GetPointValue};");
                outputFile.Write($"{goal.GetIsDone};");
                outputFile.Write($"{_timesNeededToReachBonus};");
                outputFile.Write($"{_timesCompleted};");
                outputFile.Write($"{_bonusPointValue};");
                outputFile.WriteLine("");
            }
        }
    }
    
}