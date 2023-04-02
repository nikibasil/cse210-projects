using System;

public class ProcessEvent
{
    private string eventType;
    protected string selectMessage; 

    public string eventDescription { get; private set; }

    public void GetMainMenu()
    {
        int choice = 0;      
        while (choice != 4)
            
        {
            Console.WriteLine("\nWhich Event would you like?");
            Console.WriteLine("1. Lectures");
            Console.WriteLine("2. Outdoors");
            Console.WriteLine("3. Receptions");
            Console.WriteLine("4. Exit");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1: 
                    eventType = "Lecture";
                    Console.WriteLine("You picked the Lecture Event!");
                    Lectures l = new Lectures(eventType,"My lecture", "This is the first lecture", "Dec. 30, 2022", "12pm", new Address("235", "Logan","UT"), "45", "Joe Smith");
                    MessageMenu(l);
                    Console.WriteLine(selectMessage);
                    break;

                case 2:
                    eventType = "Outdoor";
                    Console.WriteLine("You picked the Outdoor Event!");
                    Outdoors o = new Outdoors(eventType,"My outdoor event", "This is a Outdoor event description", "June 2 2020", "8:04am", new Address("662", "Rexburg","ID"), "Sunny");
                    MessageMenu(o);
                    Console.WriteLine(selectMessage);
                    break;
                case 3:
                    eventType = "Reception";
                    Console.WriteLine("You picked the Reception Event!");
                    Receptions r = new Receptions(eventType,"Reception Event 1", "This is a Reception event description", "April 20", "4:30pm", new Address("189", "Seattle", "WA"),"sally@gmail.com","yes");
                    MessageMenu(r);
                    Console.WriteLine(selectMessage);
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                    
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
        
            }
        }           
    }

    
    public string MessageMenu(Event e)
    {
        int message = 0;
         
           
        while (message != 4)
            // switch case for main menu
        {        
            Console.WriteLine("Which message would you like to view?");
            Console.WriteLine("1. Standard Message");
            Console.WriteLine("2. Short Message");
            Console.WriteLine("3. Long Message");
            Console.WriteLine("4. Exit");
            message = int.Parse(Console.ReadLine());
            Console.Clear(); 
            
            if (message == 1)
            {
                selectMessage = (e.GetStandardMessage());
                return selectMessage;
            }

            else if (message ==2)
            {
                selectMessage = (e.GetShortMessage());
                return selectMessage;
            }

            else if (message ==3)
            {
                selectMessage = (e.GetFullMessage());
                return selectMessage;
            }
        }
        return selectMessage;
    }
}