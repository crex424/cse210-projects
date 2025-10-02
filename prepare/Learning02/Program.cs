using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Programmer";
        job1._startYear = 2002;
        job1._endYear = 2006;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2010;
        job2._endYear = 2014;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();

        
    }
}