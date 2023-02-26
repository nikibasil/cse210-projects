using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        //  Console.WriteLine("Menu Options");

        int pick = -1;
        int duration;
                
        
        while (pick != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Start breathing activity"); 
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start Listing Activity");
            Console.WriteLine("   4. Quit");
            Console.WriteLine("Select a choice from the menu ");
            pick = int.Parse(Console.ReadLine());

            
            Spinner spinner1 = new Spinner();

            if (pick == 1){
                
                Breathing breathing1 = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine(breathing1.GetActivity());
                duration = breathing1.GetDuration();
                breathing1.GetReady();
                spinner1.ShowSpinnerReady();
                breathing1.StartBreathing(duration);
                breathing1.EndMessage();           
              
            }
            else if (pick  == 2){
                Reflecting reflecting1 = new Reflecting("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine(reflecting1.GetActivity());
                duration = reflecting1.GetDuration();
                reflecting1.GetReady();
                // spinner1.ShowSpinner();
                reflecting1.StartReflecting(duration);
                reflecting1.EndMessage();
            }
            else if (pick  == 3){
                Listing listing1 = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
                Console.WriteLine(listing1.GetActivity());
                duration = listing1.GetDuration();
                spinner1.ShowSpinnerReady();
                listing1.ListingActivity(duration);
                listing1.EndMessage(); 
            }
            else if (pick  == 4){
                Console.WriteLine("Goodbye!");
            }
                   
            else {
                // go back to menu
                Console.WriteLine("anything else");
            }
        }
             
    
        
    }
}
    
