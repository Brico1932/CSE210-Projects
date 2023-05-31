using System;
public class Cycling: Activity
{
    private double _speed;

    public Cycling(string date, int length, string type, int speed)
    :base(date, length, type)
    {
        _speed = speed; 
    }

    public override double CalculateDistance(Activity cycle)
    {
        double distance = cycle.GetLength() / cycle.CalculatePace(cycle); 
        
        return distance;
    }
    public override double CalculateSpeed(Activity cycle)
    {
        double speed = _speed;
        
        return speed;
    }

    public override double CalculatePace(Activity cycle)
    {
        double pace = 60/_speed;
        
        return pace;
    }


}

