using System;
// using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>()
        {
            new Video(){ _title="Video One", _author="Bill Johnson", _seconds=120},
            new Video(){ _title="Video Two", _author="Steve Owens", _seconds=240 },
            new Video(){ _title="Video Three", _author="Jessie Cook", _seconds=90},
            new Video(){ _title="Video Four", _author="Micky Mouse", _seconds=60}
        };

        // for(int i = 0; i < videos.Count; i++)
        // {
        // Console.WriteLine(videos[i]._title + videos[i]._author + videos[i]._seconds);
        // }
        // Console.ReadKey();

        videos[0].AddComments("athorname", "comment1");
        videos[1].AddComments("Joe", "comment2");
        videos[1].AddComments("Lacey", "comment2-2");
        videos[2].AddComments("sally", "comment3");
        videos[3].AddComments("lucy", "commenter4");


        foreach (Video video in videos)
        {
            
            video.DisplayVideoDetails();
            
        }    
        

    }
}