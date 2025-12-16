using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        TotalPoints points = new TotalPoints(0);
        
        int user_choice = 0;
        while (user_choice != 6)
        {
            Console.WriteLine($"You have {points.GetPoints()} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Events");
            Console.WriteLine("   6. Quit");
            user_choice = int.Parse(Console.ReadLine());
            functionCaller(user_choice, goals, points);
        }
        
        
    }

    public static void functionCaller(int user_choice, List<Goal> goals, TotalPoints points)
    {
        switch (user_choice)
        {
            case 1:
                ChooseGoalToCreate(goals);
                break;
            case 2:
                ListGoals(goals);
                break;
            case 3:
                SaveGoals(goals, points);
                break;
            case 4:
                LoadGoals(goals, points);
                break;
            case 5:
                RecordEvents(goals, points);
                break;
        }
    }

    public static void ChooseGoalToCreate(List<Goal> goals)
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        int user_choice = int.Parse(Console.ReadLine());

        switch (user_choice)
        {
            case 1:
                CreateSimpleGoal(goals);
                break;
            case 2:
                CreateEternalGoal(goals);
                break;
            case 3:
                CreateCheckListGoal(goals);
                break;
        }

    }

    public static void ListGoals(List<Goal> goals)
    {
        foreach (Goal goal in goals)
        {
            goal.DisplayGoalInfo();
        }
    }

    public static void SaveGoals(List<Goal> goals, TotalPoints points)
    {
        using (var writer = new StreamWriter("save.txt", false))
        {
            int total = points.GetPoints();
            writer.WriteLine(total);
            foreach (Goal goal in goals)
            {
                // entry._entry = entry._entry.Replace(',', '|');
                // entry._entry = entry._entry.Replace('"', '~');
                // writer.WriteLine($"{entry._date}, {entry._prompt}, {entry._entry}");

                string name = goal.GetGoalName();
                string goal_type = goal.GetType().ToString();
                string goal_desc = goal.GetDescription();
                int points_on_completion = goal.GetPointOnCompletion();
                if (goal_type.Equals("SimpleGoal"))
                {
                    bool completion = goal.IsComplete();
                    writer.WriteLine($"{goal_type}:{name},{goal_desc},{points_on_completion},{completion}");
                }

                if (goal_type.Equals("EternalGoal"))
                {
                    writer.WriteLine($"{goal_type}:{name},{goal_desc},{points_on_completion}");
                }
                if (goal is CheckListGoal checkList)
                {

                    int bonus_points = checkList.GetBonusPoints();
                    int completions_needed = checkList.GetRequiredCompletions();
                    int total_completions = checkList.GetCompletions();
                    writer.WriteLine($"{goal_type}:{name},{goal_desc},{points_on_completion},{bonus_points},{completions_needed},{total_completions}");
                }

            }
        }
    }

    public static void LoadGoals(List<Goal> goals, TotalPoints points)
    {
        try
        {
            using (StreamReader reader = new StreamReader("save.txt"))
            {
                string line;
                int total_points = int.Parse(reader.ReadLine());
                points.SetPoints(total_points);
                while ((line = reader.ReadLine()) != null)
                {
                    string[] split_line = line.Split(':', ',');
                    string goal_type = split_line[0];
                    string goal_name = split_line[1];
                    string goal_desc = split_line[2];
                    int points_on_completion = int.Parse(split_line[3]);

                    if (goal_type.Equals("SimpleGoal"))
                    {
                        bool is_fin = bool.Parse(split_line[4]);
                        SimpleGoal new_simple_goal = new SimpleGoal(goal_name, goal_desc, points_on_completion, is_fin);
                        goals.Add(new_simple_goal);
                    }

                    if (goal_type.Equals("EternalGoal"))
                    {
                        EternalGoal new_eternal_goal = new EternalGoal(goal_name, goal_desc, points_on_completion, false);
                        goals.Add(new_eternal_goal);
                    }
                    if (goal_type.Equals("CheckListGoal"))
                    {
                        int bonus_points = int.Parse(split_line[4]);
                        int completions_needed = int.Parse(split_line[5]);
                        int total_completions = int.Parse(split_line[6]);

                        CheckListGoal new_checklist_goal = new CheckListGoal(goal_name, goal_desc, points_on_completion, false, completions_needed, total_completions, bonus_points);
                        goals.Add(new_checklist_goal);
                    }

                }
            }
            
        }
        catch (Exception e)
        {

        }
    }

    public static void RecordEvents(List<Goal> goals, TotalPoints points)
    {
        int number = 1;
        int total_points = 0;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in goals)
        {
            Console.Write($"{number}. ");
            goal.SetID(number);
            goal.DisplayGoalInfo();
            number++;
        }
        Console.Write("Which goal did you accomplish? ");
        int user_choice = int.Parse(Console.ReadLine());
        foreach (Goal goal in goals)
        {
            if (goal.GetID() == user_choice)
            {
                goal.RecordEvent();
                total_points += goal.GetTotalPoints();
            }
        }
        points.SetPoints(total_points);
    }
    public static void CreateSimpleGoal(List<Goal> goals)
    {

        bool is_complete = false;

        Console.Write("What is the name of your goal? ");
        string goal_name = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = 0;
        while (is_complete == false)
        {
            try
            {
                points = int.Parse(Console.ReadLine());
                is_complete = true;
            }
            catch (Exception value_error)
            {
                Console.WriteLine("Please enter a number for the points!");
            }
        }
        SimpleGoal new_simple_goal = new SimpleGoal(goal_name, description, points, false);
        goals.Add(new_simple_goal);
    }

    public static void CreateEternalGoal(List<Goal> goals)
    {

        bool is_complete = false;

        Console.Write("What is the name of your goal? ");
        string goal_name = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = 0;
        while (is_complete == false)
        {
            try
            {
                points = int.Parse(Console.ReadLine());
                is_complete = true;
            }
            catch (Exception value_error)
            {
                Console.WriteLine("Please enter a number for the points!");
            }
        }
        EternalGoal new_eternal_goal = new EternalGoal(goal_name, description, points, false);
        goals.Add(new_eternal_goal);
    }

    public static void CreateCheckListGoal(List<Goal> goals)
    {

        bool is_complete = false;

        Console.Write("What is the name of your goal? ");
        string goal_name = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine();

        int points = 0;
        int required_completions = 0;
        int bonus_points = 0;
        while (is_complete == false)
        {
            try
            {
                Console.Write("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                required_completions = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("What is the bonus for accomplishing it that many times? ");
                bonus_points = int.Parse(Console.ReadLine());
                Console.WriteLine();
                is_complete = true;
            }
            catch (Exception value_error)
            {
                Console.WriteLine("Please enter a number for the points!");
            }
        }
        CheckListGoal new_checklist_goal = new CheckListGoal(goal_name, description, points, false, required_completions, 0, bonus_points);
        goals.Add(new_checklist_goal);
    }
    
}