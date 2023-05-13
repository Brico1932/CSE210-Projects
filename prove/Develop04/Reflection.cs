using System;
public class Reflection: Activity
{
    private List<string> _prompts = new List<string>();
    public List<string> _questions = new List<string>();

    public Reflection (string name, string description, int time)
    :base(name, description, time)
    {
        _prompts = new List<string>
        {"Think of a time when you acomplished something really difficult. ",
         "Think of a time when you were completely at peace.",
         "Think of a time when you when you felt hopeless.",
         "Think of the last good experience you had with a loved one. ",
         "Think of a time that you had to get out of your comfortzone.",
         "Think of an experience where you saw the hand of the Lord in your life.",
         "Think of a time where you failed and had to try again.",
         "Think of an experience that really helped you grow ",
         "Think of a time your heart was touched by someone's actions.",
         "Think of a time you were extremely stressed out.",
        };
        _questions = new List<string>
        {"What did you learn from this experience?",
         "What did you do differently after this experience?",
         "How did you feel during this experience?",
         "How did you feel when it was complete?",
         "What is your favorite thing about this experience?",
         "What is your least favorite thing about this experience?",
         "How did this experience effect the way you think?",
         "Would you want an experience like this to happen again?",
         "What does the Lord want you to learn from this experience?",
         "Is this an experience you want to rememer? Why or why not?",
        };
    }
    public void ReflectionActivity(Reflection activity1)
    {
    int duration = startMessage(activity1);
    List<string> completedPrompts = new List<string>();
    Console.Clear();
    Console.WriteLine("Get ready...");
    displaySpinner(5);
    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine($"---{GetPrompt(_prompts,completedPrompts)}---");
    Console.WriteLine("");
    Console.WriteLine("When you have something in mind, press enter to contine.");
    Console.ReadLine();
    Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
    displayCountDown("You may begin in",5);
    DisplayQuestions(_questions,duration);
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
    public void DisplayQuestions(List<string>questions, int duration)
    {
        Console.Clear();
        var random = new Random();
        int index = random.Next(questions.Count);
        string question = questions[index];
        List<string> completedQuestions = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (endTime > DateTime.Now)
        {
            while(completedQuestions.Contains(question))
            {
                index = random.Next(questions.Count);
                question = questions[index];
            }
           Console.Write($">{question}");
           completedQuestions.Add(question);
           displaySpinner(10);
           Console.WriteLine("");
        }
    }
}