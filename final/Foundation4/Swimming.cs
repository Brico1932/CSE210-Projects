using System;
public class Swimming: Activity
{
    private double _laps;

    public Swimming(string date, int length, string type, int laps)
    :base(date, length, type)
    {
        _laps = laps; 
    }



    public override double CalculateDistance(Activity swim)
    {
        double distance = _laps * 50 / 1000 * 0.62;
        
        return distance;
    }
    public override double CalculateSpeed(Activity swim)
    {
        double speed = 60 / swim.CalculatePace(swim);
        
        return speed;
    }

    public override double CalculatePace(Activity swim)
    {
        double pace = swim.GetLength() /swim.CalculateDistance(swim) ;
        
        return pace;
    }

}
