using System;
// using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>()
        {
            new Video(){ _title="Video One", _author="IT", _seconds=120},
            new Video(){ _title="Video Two", _author="Uncle Rico", _seconds=240 },
            new Video(){ _title="Video Three", _author="Luke Skywalker", _seconds=560},
            new Video(){ _title="Video Four", _author="Micky Mouse", _seconds=60}
        };
        
        videos[0].AddComments("Jengirl", "The elders of the Internet know who I am?");
        videos[0].AddComments("Roy", "Sorry for your loss. Move on.");
        videos[0].AddComments("Moss", "I'll just put this over here with the rest of the fire.");
        videos[1].AddComments("Pedro", "If you vote for me, all of your wildest dreams will come true.");
        videos[1].AddComments("Kip23", "We Both Know That I'm Training To Be A Cage Fighter");
        videos[1].AddComments("napolean17", "I caught you a delcious bass");
        videos[1].AddComments("ligerdeb", "Now, just imagine you're weightless, in the middle of the ocean, surrounded by tiny little seahorses.");
        videos[2].AddComments("r2man", "This is not the droid you are looking for");
        videos[2].AddComments("leia", "May the force be with you!");
        videos[2].AddComments("swfan", "Why did he do that?");
        videos[3].AddComments("cartoonguru", "This was so funny!");
        videos[3].AddComments("minnie15", "If I lived here, I'd be home already.");
        videos[3].AddComments("bugsbunny", "I bet you say that to all the wabbits.");

        foreach (Video video in videos)
        {
         
            video.DisplayVideoDetails();
            
        }    
        
    }
}