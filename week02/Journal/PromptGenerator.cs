using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the highlight of your day?",
        "What is something you learned today?",
        "How did you see the hand of the Lord in your life today?",
        "What is something you are grateful for?",
        "What made you smile today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}

