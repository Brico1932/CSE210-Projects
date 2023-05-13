using System;
public class Breathing: Activity
{
    private int _breathIn;
    private int _holdBreath;
    private int _breathOut;

    public Breathing (string name, string description, int time)
    :base(name, description, time)
    
    {
        _breathIn = 4;
        _holdBreath = 5;
        _breathOut = 6;
    }

    public void BreathingActivity(Breathing activity1)
    {
        
        int duration = startMessage(activity1);

        Console.Clear();
        Console.WriteLine("Get ready...");
        displaySpinner(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (endTime > DateTime.Now)
        {
            Console.WriteLine("");
            displayCountDown("Breathe in...", _breathIn);
            displayCountDown("Hold it in...", _holdBreath);
            displayCountDown("Breathe out...", _breathOut);
        }
        endMessage(duration);

         
    }
    

}