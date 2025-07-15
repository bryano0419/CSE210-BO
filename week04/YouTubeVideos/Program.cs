using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Cool Trick Shots", "Dude Perfect", 210);
        video1.AddComment(new Comment("Alex", "Insane shot!"));
        video1.AddComment(new Comment("Liam", "This was awesome!"));
        video1.AddComment(new Comment("Maya", "How did you even do that?!"));
        videos.Add(video1);

        Video video2 = new Video("Travel Vlog: Italy", "Emily Rose", 540);
        video2.AddComment(new Comment("Sophia", "I want to go there!"));
        video2.AddComment(new Comment("James", "Beautiful scenery."));
        video2.AddComment(new Comment("Grace", "Thanks for sharing your trip!"));
        videos.Add(video2);

        Video video3 = new Video("Learn C# in 10 Minutes", "CodeQuick", 600);
        video3.AddComment(new Comment("Tom", "Very helpful, thanks!"));
        video3.AddComment(new Comment("Anna", "Straight to the point."));
        video3.AddComment(new Comment("Kyle", "Exactly what I needed."));
        videos.Add(video3);

        Video video4 = new Video("Cat Fails Compilation", "FunnyAnimals", 300);
        video4.AddComment(new Comment("Ella", "Laughed so hard!"));
        video4.AddComment(new Comment("Luna", "Too cute."));
        video4.AddComment(new Comment("Jake", "My cat does this too!"));
        videos.Add(video4);

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length: {v.GetLength()} seconds");
            Console.WriteLine($"Comments ({v.GetNumComments()}):");
            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($" - {c.GetCommentDetails()}");
            }
            Console.WriteLine();
        }
    }
}

