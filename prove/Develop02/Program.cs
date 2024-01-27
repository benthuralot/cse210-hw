using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        PromptGenerator generator = new PromptGenerator();
        generator._prompt = new List<string>(); 
        

        Journal newJournal = new Journal();
        List<Entry> entries = new List<Entry>();
        newJournal._entries = entries;
        
        Entry anEntry = new Entry();
        anEntry._date = dateText;
        anEntry._promptText = generator.GetRandomPrompt();
        Console.WriteLine(anEntry._promptText);
        Console.Write($"> ");
        anEntry._entryText = Console.ReadLine();
        newJournal.AddEntry(anEntry);
        anEntry.Display();
        Console.Write("What is the file name? ");
        string file = Console.ReadLine();
        newJournal.SaveToFile(file);
    }
}