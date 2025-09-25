using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int fav_num = PromptUserNumber();

        int birth_year;
        PromptUserBirthYear(out birth_year);

        int square_num = SquareNumber(fav_num);
        DisplayResult(name, square_num, birth_year);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int fav_num = int.Parse(Console.ReadLine());

        return fav_num;
    }

    static void PromptUserBirthYear(out int birth_year)
    {
        Console.Write("Please enter the year you were born: ");
        birth_year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int n)
    {
        n *= n;

        return n;
    }

    static void DisplayResult(string name, int square_num, int user_birth_year)
    {
        Console.WriteLine($"{name}, the square of your number is {square_num}");

        int current_year = DateTime.Now.Year;
        int user_age = current_year - user_birth_year;
        Console.WriteLine($"{name}, you will turn {user_age} this year.");
    }

}