using System;

class Program
{
    static void Main(string[] args)
    {
        
        string new_action_str=" ";
        int new_action =0;
        while (new_action !=4 )
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            new_action_str = Console.ReadLine();
            new_action = int.Parse(new_action_str);

            if (new_action ==1)
            {
                Console.Clear();
                Breathing activity1 = new Breathing("Breathing Activity",
                "This activity will help you relax by walking you through breathing in, holding the breath, and breathing out slowly. Clear your mind and focus on your breathing"
                ,20);
                activity1.BreathingActivity(activity1);
            }
            else if(new_action == 2)
            {
                Console.Clear();
                Reflection activity1 = new Reflection("Reflection Activity",
                "This activity will help you reflect on times in your life when you have shown strenth and resilience. this will help you recognize the power you have and how you can use it in other aspects of our life."
                ,20);
                activity1.ReflectionActivity(activity1);
            }
            else if(new_action == 3)
            {
                Console.Clear();
                Listing activity1 = new Listing("Listing Activity",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in response to a specific prompt."
                ,20);
                activity1.ListingActivity(activity1);
            }
            else if(new_action == 4)
            {
                Console.Clear();
                Console.WriteLine("Thank you for taking time to be mindful!");
                Console.WriteLine("Have a wonderful day!");
            }
            else
            {
                Console.WriteLine("That is not a valid choice, please try again.");
                Thread.Sleep(3000);
            }
        }
    }
}