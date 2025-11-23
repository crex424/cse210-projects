using System;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int user_choice = 0;
        while (user_choice != 4)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            try
            {
                user_choice = int.Parse(Console.ReadLine());
                Console.Clear();
                activityCaller(user_choice);
            }
            catch
            {
                Console.WriteLine("Please enter a number such as 1, 2, 3!");
            }
        }


    }

    public static void activityCaller(int user_choice)
    {
        switch (user_choice)
        {
            case 1:
                RunBreathing();
                break;

            case 2:
                RunReflection();
                break;
            case 3:
                RunListing();
                break;
            case 4:
                break;


        }
    }

    public static void RunBreathing()
    {
        Breathing breathing = new Breathing("breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", "Well Done!!", 0);

        breathing.BeginActivity();
        int duration = breathing.GetDuration();
        Console.Clear();

        Console.Write("Get ready");
        breathing.LoadingAnimation("dots", 6);
        Console.Clear();

        DateTime start_time = DateTime.Now;
        DateTime future_time = start_time.AddSeconds(duration);
        DateTime current_time = start_time;

        while (current_time < future_time)
        {
            breathing.DisplayMessage();
            current_time = DateTime.Now;
        }
        breathing.DisplayEndMessage();
        Console.Clear();
    }
    public static void RunReflection()
    {
        List<string> ref_questions = new List<string>();
        List<string> ref_prompts = new List<string>();
        ref_questions.Add("How did you feel when it was complete?");
        ref_questions.Add("What is your favorite thing about this experience?");
        ref_questions.Add("What is something you believe you can do better next time?");
        ref_questions.Add("Would you like to do this again?");

        ref_prompts.Add("Think of a time when you did something really difficult.");
        ref_prompts.Add("Think of a time where you did something easy, but impactful.");
        ref_prompts.Add("Think of a time where you failed to succeed at something.");

        Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                                                , "Well done!!", 0, ref_prompts, ref_questions);


        reflection.BeginActivity();
        int duration = reflection.GetDuration();
        Console.Clear();

        Console.Write("Get ready");
        reflection.LoadingAnimation("dots", 6);
        Console.Clear();

        reflection.DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        DateTime start_time = DateTime.Now;
        DateTime future_time = start_time.AddSeconds(duration);
        DateTime current_time = start_time;
        int index = 0;

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        reflection.LoadingAnimation("countdown", 5);
        Console.Clear();

        while (current_time < future_time)
        {
            reflection.DisplayQuestions(index);
            current_time = DateTime.Now;
            index++;
        }
        reflection.DisplayEndMessage();
        Console.Clear();


    }

    public static void RunListing()
    {

        List<string> prompts = new List<string>();
        prompts.Add("When have you felt like you improved yourself this month?");
        prompts.Add("When did you feel confident with your schoolwork this month?");
        prompts.Add("When did you contact your family this month");
        Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Well Done!!", 0, prompts);

        listing.BeginActivity();
        int duration = listing.GetDuration();
        Console.Clear();

        Console.Write("Get ready");
        listing.LoadingAnimation("dots", 6);
        Console.Clear();

        listing.DisplayPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.Write("You may begin in: ");
        listing.LoadingAnimation("countdown", 5);

        DateTime start_time = DateTime.Now;
        DateTime future_time = start_time.AddSeconds(duration);
        DateTime current_time = start_time;

        while (current_time < future_time)
        {
            listing.AddItem();
            current_time = DateTime.Now;
        }
        Console.WriteLine($"You listed {listing.GetItemListSize()} items!");
        listing.DisplayEndMessage();
        Console.Clear();
    }
}