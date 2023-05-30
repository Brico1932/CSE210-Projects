using System;
public class Reception: Event
{
    private int _RSVP;

    public Reception (string title, string type, string description, string date, string time, string address, int RSVP)
        :base (title, type, description, date, time, address)
        {
            _RSVP = RSVP;
        }

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Please email 123@example.com to RSVP for this event.");  
    }

}