using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();

        int magic_number = r.Next(1, 100);
        Console.WriteLine($"What is the magic number? {magic_number}");

        // # I need to start the variable "guess" at something, but I don't want to start it as
        // # valid number that the computer may have chosen, so I'll start with -1
        int guess = -1;

        // # Keep going as long as the guess doesn't match the magic number
        while (guess != magic_number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // guess = int(input("What is your guess? "))

            if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}



