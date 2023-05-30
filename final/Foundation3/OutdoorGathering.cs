public class OutdoorGathering: Event
{
    private string _weather;

    public OutdoorGathering (string title, string type, string description, string date, string time, string address, string weather)
        :base (title, type, description, date, time, address)
        {
            _weather = weather;
        }
        
    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Please be advised that the expected weather for the event is : {_weather}.");  
    }
}