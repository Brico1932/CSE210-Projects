using System;

class Program
{
    static void Main(string[] args)
    {
        
        Lecture event1 = new Lecture("How to cook deep fried butter", "Lecture", 
        "Mrs. Martha stuart will give a lengthy lecture on best ways to cook deep fried butter.",
        "5/28/2024", "6:00", "123 Sesame Street",
        "Martha Stuart", 500);

        Reception event2 = new Reception("Johnson wedding", "Reception",
        "The Johnson family are proud to announce the wedding of their son Jared to Linsey McNeil",
        "6/14/2023", "6:30", "7878 Ember Street", 68);

        OutdoorGathering event3 = new OutdoorGathering("BSA Pinewood Derby", "Outdoor Gathering", 
        "Join the Boy Scouts of America for their annual Pinewood car derby races.", "7/28/2024", "5:30", "367 Jupiter park lane", "cloudy");

        event1.DisplayStandardDetails();
        Console.WriteLine();
        event1.DisplayFullDetails();
        Console.WriteLine();
        event1.DisplayShortDescription();
        Console.WriteLine();

        event2.DisplayStandardDetails();
        Console.WriteLine();
        event2.DisplayFullDetails();
        Console.WriteLine();
        event2.DisplayShortDescription();
        Console.WriteLine();

        event3.DisplayStandardDetails();
        Console.WriteLine();
        event3.DisplayFullDetails();
        Console.WriteLine();
        event3.DisplayShortDescription();
        Console.WriteLine();


    }
}