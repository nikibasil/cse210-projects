using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("What is your grade percentage? ");
    string percentage = Console.ReadLine();
    int number = int.Parse(percentage);
    string grade = "";

    if (number >= 90)
    {
      grade = "A";
      //Console.WriteLine("Your grade is an A");
    }
    else if (number >= 80)
    {
      grade = "B";
      // Console.WriteLine("Your grade is a B");
    }
    else if (number >= 70)
    {
      grade = "C";
      //Console.WriteLine("Your grade is a C");
    }
    else if (number >= 60)
    {
      grade = "D";
      //Console.WriteLine("Your grade is a D");
    }
    else
    {
      grade = "F";
      //Console.WriteLine("Your grade is an F");
    }

    if (number >= 70)
    {
      Console.WriteLine($"Your grade is a {grade}.");
      Console.WriteLine("Congratulations you passed the class!");
    }

    else
    {
      Console.WriteLine($"Your grade is a {grade}.");
      Console.WriteLine("Sorry you did not pass the class. Keep working at it!");
    }
  }


}