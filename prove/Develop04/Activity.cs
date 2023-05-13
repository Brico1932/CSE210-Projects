using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _time;

    public Activity(string name, string description,int time)
    {
        _name = name;
        _description = description;
        _time = time;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetTime()
    {
        Console.WriteLine("How long, in seconds, would you like to do this activity?");
        string time_str = Console.ReadLine();
        _time = int.Parse(time_str);
        return _time;
    }
    public int startMessage(Activity activity1)
    {
        Console.WriteLine($" Welcome to the {activity1.GetName()}!");
        Console.WriteLine(activity1.GetDescription());
        Console.WriteLine(""); 
        int duration = activity1.GetTime();
        return duration;
    }

    public void endMessage(int duration)
    {
        Console.WriteLine("");
        Console.WriteLine("Great job!");
        displaySpinner(3);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {duration} seconds of the {_name}");
        displaySpinner(5);
        
    }
    

    public void displaySpinner(int numSecondsToRun)
    {
        int spinnerCounter = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numSecondsToRun);

        while(endTime > DateTime.Now)
        {
            spinnerCounter++;
            switch(spinnerCounter %4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write(" ");
    }
    public void displayCountDown(string message, int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i>=0; i--)
        {
            Console.Write(string.Format($"{message} {i}"));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }
}