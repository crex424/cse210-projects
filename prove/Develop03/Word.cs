public class Word
{
    private string _word;

    public Word(string word)
    {
        this._word = word;
    }
    public void Hide()
    {
        string blank_space = "";
        for (int i = 0; i < _word.Count(); i++)
            blank_space += "_";
        _word = blank_space;
    }

    public void Show()
    {
        
    }

    public bool IsHidden()
    {
        if (_word.Contains("_")) 
        {
            return true;
        }
        return false;
    }

    public string GetRenderedWord()
    {
        return $"{_word} ";
    }
}