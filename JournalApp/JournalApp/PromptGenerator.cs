namespace JournalApp;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public void QuestionBank()
    {
 
            string first = "How did you see that hand of God today in your life.";
            string second = "How did you show or experience love today?";
            string third = "What about today would like to improve?";
            string fourth = "What made your day productive today?";
            string fifth = "If you had the power to, what about today would you change?";
            _prompts.Add(first);
            _prompts.Add(second);
            _prompts.Add(third);
            _prompts.Add(fourth);
            _prompts.Add(fifth);
    }

    public string SelectPrompt()
    {
        if (_prompts.Count == 0)
        {
            QuestionBank();
        }
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
}