public class ReflectionActivity : BaseActivity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "How did you feel during it?",
        "What did you learn from it?",
        "How will you apply this in the future?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times you've shown strength. It will guide you with prompts and questions.";
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_prompts[new Random().Next(_prompts.Count)]} ---");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[new Random().Next(_questions.Count)];
            Console.WriteLine($"> {question}");
            ShowSpinner(5);
        }

        DisplayEndMessage();
    }
}

