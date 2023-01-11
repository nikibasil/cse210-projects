using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int userSqNumber = SquareNumber(userNumber);

        // string user_result = DisplayResult(userName,userSqNumber);
        DisplayResult(userName,userSqNumber);
        // public string Test(int id1) { return $"Your ID is {id1}"; }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int userNumber)
        {
            int sqNumber = (userNumber * userNumber);

            // Console.WriteLine(sqNumber);
            return sqNumber;
        }

        // static string DisplayResult(string userName, int userSqNumber)
        static void DisplayResult(string userName, int userSqNumber)
        {
            Console.Write($"{userName}, the square of your number is {userSqNumber} ");
            // return userName;
        }
    }
}