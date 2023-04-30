using System;

public class Display
{
    public static string display_prompt()
    {

         var random = new Random();
         var list = new List<string>{ "What was the best thing that happened to you today?",
                                        "What is something that made you laugh today?",
                                        "What steps did you take today towards a goal you are working on?",
                                        "Who made your day better today? How can you pay that feeling forward?",
                                        "What made today unique?",
                                        "What is one thing you want to remember from today?",
                                        "When did you feel most authentically yourself today?",
                                        "How can you make tomorrow (even) better than today?"};
         int index = random.Next(list.Count);
         string prompt= list[index];
         Console.WriteLine(prompt);
         return prompt;
    }

    public static string display_date()
    {
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        Console.WriteLine(date);
        return date;
    }

            
    
}