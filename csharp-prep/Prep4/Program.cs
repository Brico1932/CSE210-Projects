using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List <int> numbers = new List<int>();
        string new_number_str = "n/a";
        int new_number = 9999;

        while (new_number != 0)
        {
            Console.WriteLine("Enter number:");
            new_number_str = Console.ReadLine();
            new_number = int.Parse(new_number_str);
            if (new_number != 0)
            {
                numbers.Add(new_number);
            }
        }
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    
    }
}