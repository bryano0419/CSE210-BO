public class ListingActivity : BaseActivity
{
    private List<string> _prompts = new List<string> {
        "Who are people you appreciate?",
        "What are personal strengths you have?",
        "What are some things that made you smile this week?",
        "Who are some personal heroes of yours?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on positive things by listing as many as you can.";
    }

    public void Run()
    {
        DisplayStartMessage();

        string prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("You may begin in: ");
        ShowCountdown(3);
        Console.WriteLine("\nStart listing. Press Enter after each item:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        DisplayEndMessage();
    }
}

