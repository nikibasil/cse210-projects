using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices");

        Prompts prompt = new Prompts();
        string displayedPrompt = prompt.DisplayPrompt();
        
        // Job job1 = new Job();
        // job1._jobTitle = "Software Engineer";
        // job1._company = "Microsoft";
        // job1._startYear = "2019";
        // job1._endYear = "2020";
        // // job1.DisplayJobDetails();
        
        // Job job2 = new Job();
        // // job2 = new Job();
        // job2._jobTitle = "Manager";
        // job2._company = "Apple";
        // job2._startYear = "2022";
        // job2._endYear = "2023";
        // // job2.DisplayJobDetails();
        // Console.WriteLine("Hello Learning02 World!");
        // Resume resume1 = new Resume();
        // // resume1 = new Resume();
        // resume1._name = "Monique Roberts";
        // resume1._jobs.Add(job1);
        // resume1._jobs.Add(job2);

        // resume1.DisplayJobDetails();
    }
}