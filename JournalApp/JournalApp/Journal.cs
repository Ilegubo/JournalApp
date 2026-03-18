namespace JournalApp;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<Entry> loadEntries = new List<Entry>();
    public void Load(string fileName)
    {
        try
        {
            if (!(fileName.Contains(".txt")))
            {
                fileName += ".txt";
            }

            string[] lines = File.ReadAllLines(fileName);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                
                if (parts.Length == 3)
                {
                    Entry newEntry = new Entry();
                    newEntry._date = parts[0];
                    newEntry._promptText = parts[1];
                    newEntry._entryText = parts[2];
                    _entries.Add(newEntry);
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error: File Not Found.");
        }
    }

    public void Save(string fileName)
    {
        if (!(fileName.Contains(".txt")))
        {
            fileName += ".txt";
        }
        try
        {
            List<string> lines = new List<string>();
            foreach (Entry pEntry in _entries)
            {

                string line = $"{pEntry._date}|{pEntry._promptText}|{pEntry._entryText}";
                lines.Add(line);
            }
            File.WriteAllLines(fileName, lines);
        }
        catch (IOException)
        {
            Console.WriteLine("Error occurred!");
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
        }
        _entries.Add(newEntry);
    }
    public void Display()
    {
        if (_entries.Count > 0)
        {
            foreach (Entry newEntry in _entries)
            {
                Console.Write($"{newEntry._date} {newEntry._promptText}\n");
                Console.WriteLine(newEntry._entryText);
            }
        }
        else

        {
            Console.WriteLine("\nNo entries found!\n");
        }
    }

}