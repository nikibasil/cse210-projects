using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        List<int> numbers = new List<int>();
        int user_num = -1;

        while (user_num != 0)
        {
           Console.Write("Enter number: ");

           string answer = Console.ReadLine();
           user_num = int.Parse(answer);

            if (user_num != 0)
            {
                numbers.Add(user_num);
            }
        }

        // # The list "numbers" now has all the numbers the user typed

        // # Step 1: Find the sum or total
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // # Step 2: Find the average
        // # We can use the sum we just computed...
        int count = (numbers.Count);
        int average = (sum / count);

        Console.WriteLine($"The average is: {average}");

        // # Step 3: Find the max
        // # We will walk through the numbers again, this time keeping track
        // # of the best so far, or the highest number to that point.

        int best = -1;

        foreach (int number in numbers)
        {
            // # Check if this number is larger than the best one we have seen so far
            if (number > best)
            {
                // # This is the new best number, so save it to that variable
                best = number;
            }
        }

        Console.WriteLine($"The largest number is: {best}");

    }
}