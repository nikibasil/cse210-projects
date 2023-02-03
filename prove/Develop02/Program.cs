using System;  
using System.IO;  
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        
        // move this to prompts
        Console.WriteLine("Welcome to the Journal Program!");

        int pick = -1;
        Journal journal1 = new Journal();
        Entry entry1 = new Entry();
        // StreamReader _fileName = new StreamReader();
        // public string filename = "myfile.txt";
        // StreamReader reader = new StreamReader(filename) 

        while (pick != 5)
        {
            Console.WriteLine("Please select one:");  
            Console.WriteLine("1. Write"); 
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.WriteLine("What would you like to do? ");
            pick = int.Parse(Console.ReadLine());

            if (pick == 1){
                journal1.AddEntry();                
            }
            else if (pick  == 2){
                journal1.DisplayFile();
            }
            else if (pick  == 3){
                
                journal1.Load();
                
            }
            else if (pick  == 4){
                // Console.WriteLine("What is your filename?" );
                journal1.Save();
            }
                   
            else if (pick  == 5){
                Console.WriteLine("Goodbye!");
            }
            else {
                // go back to menu
                Console.WriteLine("anything else");
            }
        }
             
    }

}