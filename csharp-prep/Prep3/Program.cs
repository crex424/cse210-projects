using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magic_num = int.Parse(Console.ReadLine());
        bool guess_correct = false;
        while (guess_correct != true)
        {
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == magic_num)
            {
                guess_correct = true;
                Console.WriteLine("You Guessed It!");
            }
            else if (guess > magic_num)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                Console.WriteLine("Higher.");
            }
        }

    }
}