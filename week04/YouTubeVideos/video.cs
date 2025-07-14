using System.Collections.Generic;

public class Video
{
    public string title;
    public string author;
    public int length;
    public List<Comment> comments;

    public int GetNumComments()
    {
        return comments.Count;
    }
}
