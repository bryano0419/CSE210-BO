public class Reference
{
    public string Book;
    public int Chapter;
    public int StartVerse;
    public int EndVerse;

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
        EndVerse = 0;
    }

    public string GetReference()
    {
        return Book + " " + Chapter + ":" + StartVerse + "-" + EndVerse;
    }
}
