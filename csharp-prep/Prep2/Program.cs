using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradePercent = Console.ReadLine();
        int gradePercentNum = int.Parse(gradePercent);
        string letter = "N/A";
        bool Pass_Fail = false;
        string Message = "N/A";
        if (gradePercentNum >= 90)
        {
            letter = "A";
            Pass_Fail = true;

        }
        else if (gradePercentNum >= 80 && gradePercentNum < 90)
        {
            letter = "B";
            Pass_Fail = true;

        }
        else if (gradePercentNum >= 70 && gradePercentNum < 80)
        {
            letter = "C";
            Pass_Fail = true;

        }
        else if (gradePercentNum >= 60 && gradePercentNum < 70)
        {
            letter = "D";
            Pass_Fail = false;

        }
        else
        {
            letter = "F";
            Pass_Fail = false;

        }

        if (Pass_Fail == true)
        {
            Message = "Congradulations!!! You passed the class!";
        }
        else
        {
            Message = "I'm sorry, but you didn't pass the class. Study up a little more and try again!";
        }

        Console.WriteLine($"With that score you recieve the letter grade {letter}");
        Console.WriteLine("");
        Console.WriteLine(Message);
        Console.WriteLine("");
    }
}