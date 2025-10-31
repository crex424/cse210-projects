using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assign1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assign1.GetSummary());
        Console.WriteLine(assign1.GetHomework());

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}