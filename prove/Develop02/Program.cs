using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;

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

        Console.WriteLine("Welcome to the Journal Program!");

        while(true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Entry anEntry = new Entry();
                anEntry._date = dateText;
                anEntry._promptText = generator.GetRandomPrompt();
                Console.WriteLine(anEntry._promptText);
                Console.Write($"> ");
                anEntry._entryText = Console.ReadLine();
                newJournal.AddEntry(anEntry);
            }

            else if (userChoice == 2)
            {
                newJournal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.Write("What is the file name?");
                string fileName = Console.ReadLine();
                newJournal.LoadFromFile(fileName);                
            }
            else if (userChoice == 4)
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                newJournal.SaveToFile(file);
            }
            else if (userChoice == 5)
            {
                Console.WriteLine("Goodbye.");
                break;
            }

        }
    }
}