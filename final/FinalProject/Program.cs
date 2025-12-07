using System;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int user_choice = 0;
        while (user_choice != 8)
            Console.WriteLine("In this program you will be able to view different types of insurances and their particular companies and see which people are currently enrolled in it.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1: View Medical Insurance");
            Console.WriteLine("    2: View Dental Insurance");
            Console.WriteLine("    3: View Vision Insurance");
            Console.WriteLine("    4: View Life Insurance");
            Console.WriteLine("    5: View Housing Insurance");
            Console.WriteLine("    6: View Rental Insurance");
            Console.WriteLine("    7: View Car Insurance");
            Console.WriteLine("    8: quit");
            Console.Write("> ");
            user_choice = int.Parse(Console.ReadLine());

        switch (user_choice)
        {
            case 1:
                ViewMedical();
                break;
            case 2:
                ViewDental();
                break;
            case 3:
                ViewVision();
                break;
            case 4:
                ViewLife();
                break;
            case 5:
                ViewHousing();
                break;
            case 6:
                ViewRental();
                break;
            case 7:
                ViewCar();
                break;
            case 8:
                break;
        }
    }

    public static void ViewMedical()
    {
        Console.WriteLine("pretend there is a list of different medical insurances such as Blue Cross Blue Shield.");
    }

    public static void ViewDental()
    {
        Console.WriteLine("pretend there is a list of different dental insurances such as Blue Cross Blue Shield.");
    }

    public static void ViewVision()
    {
        Console.WriteLine("pretend there is a list of different vision insurances such as Blue Cross Blue Shield.");
    }

    public static void ViewLife()
    {
        Console.WriteLine("pretend there is a list of different life insurances such as Blue Cross Blue Shield.");
    }
    public static void ViewHousing()
    {
        Console.WriteLine("pretend there is a list of different housing insurances such as Blue Cross Blue Shield.");
    }
    public static void ViewRental()
    {
        Console.WriteLine("pretend there is a list of different rental insurances such as Blue Cross Blue Shield.");
    }
    public static void ViewCar()
    {
        Console.WriteLine("pretend there is a list of different car insurances such as Blue Cross Blue Shield.");
    }
}