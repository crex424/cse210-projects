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
    public void SaveJournal()
    {
        Console.WriteLine("What is the file name?");
        string file_name = Console.ReadLine();
        
        using (var writer = new StreamWriter(file_name, false))
        {
            foreach (Entry entry in _entries)
            {
                entry._entry = entry._entry.Replace(',', '|');
                entry._entry = entry._entry.Replace('"', '~');
                writer.WriteLine($"{entry._date}, {entry._prompt}, {entry._entry}");
            }
        }
    }

    public Journal LoadJournal()
    {
        Journal loaded_journal = new Journal();

        bool is_found = false;
        while (is_found == false)
        {
            Console.WriteLine("What is the file name?");
            string file_name = Console.ReadLine();
            try
            {
                using (StreamReader reader = new StreamReader(file_name))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] split_line = line.Split(',');
                        string date = split_line[0];
                        string prompt = split_line[1];
                        string entry = split_line[2];

                        entry = entry.Replace('|', ',');
                        entry = entry.Replace('~', '"');

                        Entry new_entry = new Entry();
                        new_entry._date = date;
                        new_entry._prompt = prompt;
                        new_entry._entry = entry;

                        loaded_journal._entries.Add(new_entry);

                        is_found = true;
                    }
                }
            }    
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        
        } 
        return loaded_journal;
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
}