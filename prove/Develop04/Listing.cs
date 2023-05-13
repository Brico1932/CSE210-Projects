using System;
public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private int _numberOfResponses;

    public Listing (string name, string description, int time)
    :base(name, description, time)
    {
        _prompts = new List<string>{"Name the things that have made you smile today.",
         "When have you seen the Lords hand in your life this month?",
         "Name the positive things that have happened this week.",
         "What are you gratful for this month?",
         "What are your favorite foods and why are they your favorites?",
         "What pieces of advice would you give your 16 year old self?",
         "What are some things you are really good at?",
         "Name the places you feel the most peace?",
         "Which songs make you want to sing along?",
         "What activities would you do if you had unlimited free time?"};
         _numberOfResponses = 0;
    }

        public void ListingActivity(Listing activity1)
    {
        
        int duration = startMessage(activity1);
        List<string> completedPrompts = new List<string>();
        

        Console.Clear();
        Console.WriteLine("Get ready...");
        displaySpinner(5);
        Console.WriteLine("List as many responeses as you can to the following prompt:");
        string prompt = GetPrompt(_prompts,completedPrompts);
        Console.WriteLine("");
        Console.WriteLine($"--------{prompt}--------");
        completedPrompts.Add(prompt);
        displayCountDown("You may begin in:",5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        Console.WriteLine("");

        while (endTime > DateTime.Now)
        {

            Console.Write(">");
            Console.ReadLine();
            _numberOfResponses++;  
        }
        
        Console.WriteLine($"You listed {_numberOfResponses} items!");
        Console.WriteLine("");
        endMessage(duration);
    }

    public string GetPrompt(List<string> prompts, List<string> completedPrompts)
    {
        
        var random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        bool alreadyDone = completedPrompts.Contains(prompt);
        while (alreadyDone == true)
        {
           index = random.Next(prompts.Count);
        }
        prompt = prompts[index];
        return prompt; 
    }

}