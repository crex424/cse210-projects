using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> list_n = new List<int>();
        bool keep_going = true;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (keep_going == true)
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                keep_going = false;
            }
            else
            {
                list_n.Add(number);
            }
        }
        decimal sum = 0;
        int largest = 0;
        foreach (int n in list_n)
        {
            if (n > largest)
            {
                largest = n;
            }
            sum += n;
        }
        
        decimal average = sum / list_n.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}