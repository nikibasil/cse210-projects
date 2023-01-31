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

            Journal journal1 = new Journal();

            Entry entry1 = new Entry();

            if (pick == 1){
                Console.WriteLine("1");
                journal1.AddEntry();                
            }
            else if (pick  == 2){
                Console.WriteLine("2");
                journal1.DisplayFile();
            }
            else if (pick  == 3){
                Console.WriteLine("You picked 3");
                // /journal1.LoadFile(StreamReader _);
                journal1.LoadFile();
                // string[] lines =  System.IO.File.ReadAllLines;
            }
            else if (pick  == 4){
                Console.WriteLine("What is your filename?" );
                // journal1.filename = Console.ReadLine();
                journal1.ProcessFiles();
                // File.savetofile(Entry.entry1._date,entry1._prompt, entry1._response);
                          
                // Console.WriteLine("What is the filename? ");
                // journal.fileName = Console.ReadLine();
                // journal.SaveFile();
                // journal1.proecessfile
                }
            
            else if (pick  == 5){
                Console.WriteLine("Goodbye!");
            }
            else {
                // go back to menu
                Console.WriteLine("anything else");
            }
        }

        // Console.WriteLine("Please select one of the following choices");
        
        // used to get a prompt (string promptString = prompt.Get();)
        // public string.getPrompt 
        
        // string displayedPrompt = prompt.DisplayPrompt();
        
    

        // Journal newJournal = new Journal();
        // newJournal.Menu()

        
    }

    
        
    
}