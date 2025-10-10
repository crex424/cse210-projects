using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        GeneratePrompt prompts = new GeneratePrompt();
        prompts._prompts.Add("What was my favorite part of the day?");
        prompts._prompts.Add("What was the worse part of the day?");
        prompts._prompts.Add("What is something I accomplished today?");
        prompts._prompts.Add("How did I spend my day?");
        prompts._prompts.Add("How would I improve my day next time?");

        bool finish = false;
        while (finish == false)
        {
            DisplayMenu();
            int user_choice = GetUserInput();
            switch (user_choice)
            {
                case 1:
                    Entry entry = WriteEntry(prompts);
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    journal = journal.LoadJournal();
                    break;
                case 4:
                    journal.SaveJournal();
                    break;
                case 5:
                    finish = true;
                    break;
                default:
                    Console.WriteLine("Please choose a number option from the menu!");
                    break;
            }
        }




    }
    public static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }

    public static int GetUserInput()
    {

        Console.Write("What would you like to do? ");
        int user_choice = int.Parse(Console.ReadLine());

        return user_choice;

    }

    public static Entry WriteEntry(GeneratePrompt prompts)
    {
        Entry entry = new Entry();
        string prompt = prompts.GetPrompt();

        Console.WriteLine(prompt);
        Console.Write("> ");

        entry._entry = Console.ReadLine();
        entry._date = entry.GetDate();
        entry._prompt = prompt;

        return entry;

    }
}