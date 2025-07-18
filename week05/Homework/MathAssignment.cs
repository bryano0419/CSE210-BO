public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textbookSection, string problems)
        : base("Roberto Rodriguez", "Fractions") // Hardcoded for now
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method missing
}

