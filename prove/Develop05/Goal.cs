using System;
public class Goal
{
    private string _name;
    private int _type;
    private string _description;
    private int _pointValue;
    bool _isDone;

    public Goal(string name, int type, string description, int pointValue, bool isDone)
    {
        _name = name;
        _type = type;
        _description = description;
        _pointValue = pointValue; 
        _isDone = isDone; 
    }
    public string GetName()
    {
         return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPointValue()
    {
        return _pointValue;
    }
    public bool SetIsDone(Goal goal)
    {
        _isDone = true;
        return _isDone;
    }
    public bool GetIsDone(Goal goal)
    {
        return _isDone;
    }
    public virtual void CompleteGoal(Goal completedgoal)
    {
    }
    public virtual int PointsToTotal(Goal completedgoal)
    {
        return _pointValue;
    }
    
    public virtual void CreateGoal(List<Goal> allgoals, int type)
    {   
    }
    public virtual void DisplayGoals(Goal goal, int counter)
    {
        if (_isDone == false)
        {
            Console.WriteLine($"{counter}. [ ] {goal.GetName()} ({goal.GetDescription()})");
        }
        else
        {
            Console.WriteLine($"{counter}. [X] {goal.GetName()} ({goal.GetDescription()})");
        }
    }
    
    public virtual void RecordEvent(List<Goal> allgoals)
    {

    }

public virtual void LoadGoals(List<Goal> allgoals,string file_name)
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
            Goal newgoal = new Goal(name,type,description,pointValue,isdone);
            allgoals.Add(newgoal);
        }
    }

    public virtual void SaveGoals(List<Goal> allgoals, string file_name)
    {
        foreach(Goal goal in allgoals)
        {
            string path = file_name;
            using (StreamWriter outputFile = File.AppendText(path))
            {
                outputFile.Write($"{goal._name};");
                outputFile.Write($"{goal._type};");
                outputFile.Write($"{goal._description};");
                outputFile.Write($"{goal._pointValue};");
                outputFile.Write($"{goal._isDone};");
                outputFile.WriteLine("");
            }
        }
    
    }
}