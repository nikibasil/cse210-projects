using System;
using System.Collections.Generic;

public class Video
{

    public string _title;
    // { get; set; }
    public int _seconds;
    //  { get; set; }
    public string _author;
    public int _commentCount;
    protected List<Comment> _comments = new List<Comment>();
    
    
    
    public void AddComments(string commenterName, string commenterText)
    {

        Comment comment = new Comment(commenterName,commenterText);
        _comments.Add(comment);

    }

    public void DisplayVideoDetails()  
    {

        Console.WriteLine($"Title: {_title}, Seconds: {_seconds}, Author: {_author} \n");
        Console.WriteLine($"{_commentCount} Comments:");
       
        foreach(Comment comment in _comments)
        {
            // _commentCount = comment.Count();
            // _commentCount = comment.Count(c => c == "");
            
            Console.WriteLine($"{comment.GetCommentName()}: {comment.GetCommentText()} ");
        }
         
               
    }

    // public int GetCommentsCount()
    // {

    // }

}


