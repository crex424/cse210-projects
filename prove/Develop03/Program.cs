using System;

class Program
{
    static void Main(string[] args)
    {
        string verse_text = "Yea, I make a record in the language of my father, which consists of the learning of the Jews and the language of the Egyptians.";
        string[] verse_word = verse_text.Split(' ');
        Reference reference1 = new Reference("1 Nephi", 1, 2);
        List<Word> words1 = new List<Word>();
        foreach (string word in verse_word)
        {
            Word test_word = new Word(word);
            words1.Add(test_word);
        }
        Scripture scripture1 = new Scripture(reference1, words1);
        string is_done = " ";
        while (is_done != "quit")
        {
            Console.WriteLine(scripture1.GetRenderedText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            is_done = Console.ReadLine();
            if (is_done != "quit")
            {
                if (!scripture1.IsCompletelyHidden())
                {
                    scripture1.HideWords();
                    Console.Clear();
                }
                else
                {
                    is_done = "quit";
                }
            }
        }
    }
}