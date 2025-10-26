using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> words)
    {
        this._reference = reference;
        this._words = words;
    }

    public string GetRenderedText()
    {
        string scripture_text = $"{_reference.GetScripture()} ";
        foreach (Word word in _words)
        {
            scripture_text += word.GetRenderedWord();
        }
        return scripture_text;
    }

    public void HideWords()
    {
        bool is_correct = false;
        int words_to_disappear = 3;

        while (is_correct == false)
        {
            try
            {
                Console.Write("How many words do you want to disappear each time? ");
                words_to_disappear = int.Parse(Console.ReadLine());
                if (words_to_disappear <= _words.Count())
                {
                    is_correct = true;
                }
                else
                {
                    Console.WriteLine($"Please enter a number between 1 and {_words.Count()}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please input a number(1, 2, 3, ect)");
            }
        }
        
        
        Random random = new Random();
        List<int> used_rand = new List<int>();
        for (int i = 0; i < words_to_disappear; i++)
        {
            int rand = 0;
            bool is_not_duplicate = false;
            while (is_not_duplicate == false)
            {
                rand = random.Next(_words.Count());
                if (!used_rand.Contains(rand))
                {
                    is_not_duplicate = true;
                    used_rand.Add(rand);
                }
                else
                {
                    is_not_duplicate = false;
                }

            }
            
            Word word = _words[rand];
            if (!word.IsHidden())
            {
                word.Hide();
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetRenderedWord().Contains('_'))
            {
                return false;
            }
        }
        return true;
    }
}