using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string name = PromptName();
        int number = PromptUserNumber();
        int squared_number =SquareNumber(number);

        DisplayResults(name, squared_number);       
    }


    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");

    }

    static string PromptName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        string favorite_number = Console.ReadLine();
        int fav_number= int.Parse(favorite_number);
        return fav_number;
    }

    static int SquareNumber(int number)
    {
        int squared_number = number * number;
        return squared_number;
    }

    static void DisplayResults(string name, int squared_number)
    {
        Console.WriteLine($"{name}, the square of your number is {squared_number}");

    }
}