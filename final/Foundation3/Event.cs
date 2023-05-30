using System;
public class Event
{
    private string _title;
    private string _type;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    public  Event(string title, string type, string description, string date, string time, string address)
    {
        _title = title;
        _type = type;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Tile: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
    }
    public virtual void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Type: {_type}"); 
    }
    public void DisplayShortDescription()
    {
        Console.WriteLine($"{_type}"); 
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_date}"); 
    }
}