using System;
using System.IO;
using System.Text;

public class Load
{
    public static void Load_Entries()
    {
        string file_name = "Journal.txt";
        string[] lines = File.ReadAllLines(file_name);
        ;
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}

public class Save
{
    public static void Save_Entries()
    {
        foreach(Entry i in Program._entries_from_today)
        {
            string path = "Journal.txt";
            using (StreamWriter outputFile = File.AppendText(path))
            {
                outputFile.WriteLine($"{i._date}");
                outputFile.WriteLine($"{i._prompt}");
                outputFile.WriteLine($"{i._newEntry}");
            }
        }
    
    }

}