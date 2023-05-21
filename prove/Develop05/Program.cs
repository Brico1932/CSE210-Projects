using System;

class Program
{
    static void Main(string[] args)
    {
        
        string new_action_str=" ";
        int new_action =0;
        int TotalPoints = 0;
        List<Goal> allgoals = new List<Goal>();
        while (new_action !=6 )
        {
            Console.Clear();
            Console.WriteLine($"You have {TotalPoints} points!");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            new_action_str = Console.ReadLine();
            new_action = int.Parse(new_action_str);

            if (new_action ==1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                string GoalTypeStr= Console.ReadLine();
                int goaltype = int.Parse(GoalTypeStr);
                if (goaltype == 1)
                {
                    SimpleGoal newgoal = new SimpleGoal("",0,"",0,false);
                    newgoal.CreateGoal(allgoals,goaltype);
                }
                else if (goaltype == 2)
                {
                    EternalGoal newgoal = new EternalGoal("",0,"",0,false);
                    newgoal.CreateGoal(allgoals, goaltype);
                }
                else if (goaltype == 3)
                {
                    ChecklistGoal newgoal = new ChecklistGoal("",goaltype,"",0,false,0,0,0);
                    newgoal.CreateGoal(allgoals, goaltype);
                }
            }
                
            else if(new_action == 2)
            {
                Console.Clear();
                int counter = 0;
                foreach(Goal goal in allgoals)
                {
                    counter++;
                    goal.DisplayGoals(goal, counter);
                }
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
                
            else if(new_action == 3)
            {
               Goal newgoal = new Goal("",0,"",0,false);
               Console.WriteLine("What is the name of the file where you would like to save your goals?");
               string file_name = Console.ReadLine();
               newgoal.SaveGoals(allgoals,file_name);
                
            }
            else if(new_action == 4)
            {
                Goal newgoal = new Goal("",0,"",0,false);
               Console.WriteLine("What is the name of the file where you would like to load your goals from?");
               string file_name = Console.ReadLine();
               newgoal.LoadGoals(allgoals,file_name);
            }
                
            else if(new_action == 5)
            {
               int counter = 0;
                foreach(Goal goal in allgoals)
                {
                    counter++;
                    Console.WriteLine($"{counter}. {goal.GetName()}");
                } 
                Console.WriteLine("Which goal did you accomplish?");
                string eventgoalstr = Console.ReadLine();
                int eventgoal = int.Parse(eventgoalstr);
                int index = eventgoal-1;
                Goal completedgoal = allgoals.ElementAt(index);
                completedgoal.CompleteGoal(completedgoal);
                int pointsfromevent = completedgoal.PointsToTotal(completedgoal);
                TotalPoints = TotalPoints + pointsfromevent;
                Console.WriteLine($"Congradulations! You have earned {pointsfromevent} points!");
                Console.WriteLine($"You now have {TotalPoints} points!");
            }
            else if (new_action == 6)
            {
                Console.WriteLine("Thank you for using the Eternal Quest goal program!!!");
            }
        }
    }
}