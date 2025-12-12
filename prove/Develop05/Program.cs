using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        
        int user_choice = 0;
        while (user_choice != 6)
        {
            Console.WriteLine($"You have {} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Events");
            Console.WriteLine("   6. Quit");
            user_choice = int.Parse(Console.ReadLine());
            functionCaller(user_choice, goals);
        }
        
        
    }

    public static void functionCaller(int user_choice, List<Goal> goals)
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
                SaveGoals(goals);
                break;
            case 4:
                LoadGoals(goals);
                break;
            case 5:
                RecordEvents(goals);
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

    public static void SaveGoals(List<Goal> goals)
    {
        
    }

    public static void LoadGoals(List<Goal> goals)
    {
        
    }

    public static void RecordEvents(List<Goal> goals)
    {
        
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