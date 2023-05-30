using System;
public class Lecture: Event
{
    private string _speaker;
    private int _capacity;

    public Lecture (string title, string type, string description, string date, string time, string address, string speaker, int capacity)
        :base (title, type, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }
    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        
        Console.WriteLine($"Speaker: {_speaker}"); 
        Console.WriteLine($"Capacity: {_capacity}"); 
    }

}