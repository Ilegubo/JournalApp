namespace JournalApp;

public class Entry
{
    
    public string _date = DateTime.Now.ToShortDateString();
    public string _promptText = new PromptGenerator().SelectPrompt();
    public string _entryText;
    

    public void Display()
    {
        Console.WriteLine($"{_date}\n{_promptText}\n{_entryText}");
    }
}