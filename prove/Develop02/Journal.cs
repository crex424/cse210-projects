public class Journal
{
    public string _journal_name;
    public List<Entry> _entries = new List<Entry>();

    public void DisplayJournal()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            _entries[i].Display();
        }
    }
    public bool SaveJournal()
    {
        var writer = new StreamWriter("journal_storage.csv");

        return true;
    }

    public Journal LoadJournal()
    {
        Journal loaded_journal = new Journal();
        return loaded_journal;
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
}