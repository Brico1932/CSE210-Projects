using System;
public class Running: Activity
{
    private double _distance;

    public Running(string date, int length, string type, double distance)
    :base(date, length, type)
    {
        _distance = distance; 
    }

    public override double CalculateDistance(Activity run)
    {
        double distance = _distance;
        
        return distance;
    }
    public override double CalculateSpeed(Activity run)
    {
        double speed = (_distance / run.GetLength()) * 60;
        
        return speed;
    }

    public override double CalculatePace(Activity run)
    {
        double pace = 60 / run.CalculateSpeed(run);
        
        return pace;
    }

}
