using System.Collections.Concurrent;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }

    public Reference(string book, int chapter, int verse, int end_verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = end_verse;
    }

    public static string GetScripture()
    {
        return "test";
    }
}