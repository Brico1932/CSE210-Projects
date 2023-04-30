using System.IO;

public class Entry
{

    public string _newEntry;
    public string _date;
    public string _prompt;

     public void DisplayEntry()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_newEntry}");
    }
    
}

public class Recent_Entries
{
    public List<Entry> _entries_from_today = new List<Entry>();

}

