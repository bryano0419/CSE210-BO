public class BreathingActivity : BaseActivity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing slowly. Clear your mind and focus on your breath.";
    }

    public void Run()
    {
        DisplayStartMessage();

        int cycleTime = 6; // 3 sec in, 3 sec out
        int cycles = _duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(3);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            ShowCountdown(3);
            Console.WriteLine();
        }

        DisplayEndMessage();
    }
}

