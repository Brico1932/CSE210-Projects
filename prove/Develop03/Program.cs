using System;

class Program
{
    static void Main(string[] args)
    {
        string input ="";
        Reference reference = new Reference("2 Nephi", "2","25","26");
        Scripture scripture = new Scripture( reference,"Adam fell that men might be; and men are, that they might have joy. And the messiah cometh in the fulness of time that he may redeem the children of men from the fall.");

        while(input != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Hit enter to continue or 'quit' to end the program:");
            input = Console.ReadLine();
            scripture.HideWord();
        } 
        Console.Clear();
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine();
        Console.WriteLine("Yay, you memorized the scripture!");
    } 
}