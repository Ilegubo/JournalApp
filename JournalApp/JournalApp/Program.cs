using System;
using JournalApp;

class Program
{
    
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        bool quit = false;
        do
        {
            Menu();
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Console.Write("File Name: ");
                string fileName = Console.ReadLine();
                _journal.Load(fileName);
            }

            else if (userChoice == "2")
            {
                Console.Write("File Name: ");
                string fileName = Console.ReadLine();
                _journal.Save(fileName);
            }

            else if (userChoice == "3")

            {
                Entry entry = new Entry();
                _journal.AddEntry(entry);
            }

            else if (userChoice == "4")
            {
                _journal.Display();
            }

            else if (userChoice == "5")
            {
                Console.WriteLine("Exiting...");
                quit = true;
            }
        } while (quit == false);
    }

    static void Menu()
    {
        Console.WriteLine("1: Load File");
        Console.WriteLine("2: Save File");
        Console.WriteLine("3: Write Entry");
        Console.WriteLine("4: Display Entries");
        Console.WriteLine("5:Quit");
        Console.Write("\nOption: ");
    }
}