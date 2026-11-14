using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What did I learn from someone today?",
        "What small achievement made me proud today?",
        "How did I help someone today?",
        "What challenge did I face, and how did I respond?",
        "What am I grateful for today?",
        "What would I like to improve tomorrow?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}