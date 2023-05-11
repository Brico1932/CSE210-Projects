using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Geovani Rocket", "Pokemon studies");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Jessie Meowth","Muliplication","5.4","2-10");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("James Meowth","U.S. History","Manifest destiny");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo());
    }
}