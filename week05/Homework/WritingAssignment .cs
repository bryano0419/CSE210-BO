public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string title)
        : base("Mary Waters", "European History") // Hardcoded for now
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return _title + " by " + _studentName; // Error: _studentName is private
    }
}

