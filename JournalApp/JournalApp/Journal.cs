namespace JournalApp;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void Load(string fileName)
    {
        try
        {
            string entries = File.ReadAllText(fileName);
        }
        catch (IOException)
        {
            Console.WriteLine("Error 404: File Not Found.");
        }
    }

    public void Save(string fileName)
    {
        try
        {
            foreach (Entry pEntry in _entries)
            {
                string content = $"{pEntry._date} {pEntry._promptText}\n{pEntry._entryText}";
                File.WriteAllText(fileName, content);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error occured!");
        }
    }

    public void AddEntry(Entry newEntry)
    {
        newEntry._entryText = "";
        while (string.IsNullOrEmpty(newEntry._entryText))
        {
            Console.WriteLine(newEntry._promptText);
            Console.Write("Response: ");
            newEntry._entryText = Console.ReadLine();
            newEntry._entryText += " | ";
        }
        _entries.Add(newEntry);
    }
    public void Display()
    {
        if (_entries.Count > 0)
        {
            foreach (Entry newEntry in _entries)
            {
                Console.Write($"{newEntry._date} {newEntry._promptText}");
                Console.WriteLine(newEntry._entryText);
            }
        }
        else

        {
            Console.WriteLine("\nNo entries found!\n");
        }
    }

}