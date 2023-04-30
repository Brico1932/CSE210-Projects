using System;

class Program
{
    static public List<Entry> _entries_from_today = new List<Entry>();

    static void Main(string[] args)
    {
        string action_str = "oops";
        int action_new = 0;
        
        
        while (action_new != 5)
        {
            Console.WriteLine("Please select on of the folowing choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            action_str = Console.ReadLine();
            action_new = int.Parse(action_str);
            
            
            if (action_new == 1)
            {
              
              Entry entry = new Entry();
              entry._date = Display.display_date();
              entry._prompt = Display.display_prompt();
              entry._newEntry = Console.ReadLine();
              _entries_from_today.Add(entry);
                
            }
            else if(action_new == 2)
            {
                
                foreach(Entry i in _entries_from_today)
                {
                    i.DisplayEntry();
                }
            }
            else if(action_new == 3)
            {
              Load.Load_Entries();  
            }
            else if(action_new == 4)
            {
               Save.Save_Entries();
            }
            else if(action_new == 5)
            {
              Console.WriteLine("Thank you for writing in your Journal!");  
            }


        }


    }
}
