public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        //Entry entry = new Entry();
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using StreamWriter outputFile = new StreamWriter(fileName);
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}");
        }
    }

    public void LoadFromFile(string file)
    {
        
    }
}