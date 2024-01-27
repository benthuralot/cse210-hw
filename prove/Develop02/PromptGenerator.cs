public class PromptGenerator
{
    public List<string> _prompt;

    public void AddPrompts()
    {
       _prompt.Add("How was your day today?");
       _prompt.Add("If I had one thing I could do over today, What would it be?");
       _prompt.Add("What was the best part of my day?");
       _prompt.Add("Who was the most interesting person you interacted with today?");
       _prompt.Add("What was the most challenging thing I faced today?");
       _prompt.Add("What am I grateful for today?");
       _prompt.Add("What did I do today that I am proud of?");
       _prompt.Add("What was the worst thing that happened today?");
       _prompt.Add("What was the best thing that happened today?");
       _prompt.Add("What are my top priorities for the day?");
       _prompt.Add("What am I nervous or anxious about today?");
       _prompt.Add("What was a small detail I noticed today?");
       _prompt.Add("What was the weather like today?");
       _prompt.Add("How can I make tomorrow even better?");
       _prompt.Add("What did I learn today?");
    }

    public string GetRandomPrompt()
    {
        AddPrompts();
        Random random = new Random();
        int idx = random.Next(0, _prompt.Count);
        string randomPrompt = _prompt[idx];
        return randomPrompt;
    }
}