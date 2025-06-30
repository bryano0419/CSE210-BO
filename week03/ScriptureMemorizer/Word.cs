public class Word
{
    public string text;
    public bool hidden;

    public Word(string t)
    {
        text = t;
        hidden = false;
    }

    public string Display()
    {
        if (hidden)
        {
            return "____";
        }
        else
        {
            return text;
        }
    }
}
