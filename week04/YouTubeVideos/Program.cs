using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Video video = new Video();
        video.title = "Title";
        video.author = "Author";
        video.length = 120;

        Comment comment = new Comment();
        comment.commenterName = "Bob";
        comment.commentText = "Nice video!";
        video.comments.Add(comment);

        Console.WriteLine(video.title);
    }
}
