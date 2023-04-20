using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        string guess_str = "n/a";
        int guess = 9999;
        int counter = 0;

        
        while (magic_number != guess)
        {
            Console.WriteLine("What is your guess?");
            guess_str = Console.ReadLine();
            guess = int.Parse(guess_str);
            counter = counter + 1;

            if (magic_number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_number < guess)
            {
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine("Congradulations! You guessed it!");
        Console.WriteLine($"You made {counter} guesses.");


    }
}