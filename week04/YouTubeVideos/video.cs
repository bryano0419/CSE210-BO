using System.Collections.Generic;

public class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumComments()
    {
        return comments.Count;
    }

    public string GetTitle() => title;
    public string GetAuthor() => author;
    public int GetLength() => length;
    public List<Comment> GetComments() => comments;
}

