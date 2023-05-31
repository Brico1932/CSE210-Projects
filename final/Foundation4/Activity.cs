using System;
public class Activity
{
    private string _date;
    private double _length;
    private string _type;

    public Activity(string date, double length, string type)
    {
        _date = date;
        _length = length;
        _type = type;
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetLength()
    {
        return _length;
    }
    public string GetSummary(Activity activity)
    {
        string summary = $"{_date} {_type} ({_length} min)- \n Distance: {activity.CalculateDistance(activity)} miles,\n Speed: {activity.CalculateSpeed(activity)} mph,\n Pace: {activity.CalculatePace(activity)} min per mile";
        return summary;
    }
    public virtual double CalculateDistance(Activity activity)
    {
        double distance = 0;
        
        return distance;
    }
    public virtual double CalculateSpeed(Activity activity)
    {
        double speed = 0;
        
        return speed;
    }

    public virtual double CalculatePace(Activity activity)
    {
        double pace = 0;
        
        return pace;
    }

}



