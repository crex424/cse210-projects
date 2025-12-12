using System;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        
        InsuranceStorage storage = new InsuranceStorage();
        int user_choice = 0;
        while (user_choice != 8)
        {
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
                    Console.Clear();
                    ViewMedical(storage);
                    break;
                case 2:
                    Console.Clear();
                    ViewDental(storage);
                    break;
                case 3:
                    Console.Clear();
                    ViewVision(storage);
                    break;
                case 4:
                    Console.Clear();
                    ViewLife(storage);
                    break;
                case 5:
                    Console.Clear();
                    ViewHousing(storage);
                    break;
                case 6:
                    Console.Clear();
                    ViewRental(storage);
                    break;
                case 7:
                    Console.Clear();
                    ViewCar(storage);
                    break;
                case 8:
                    Console.Clear();
                    break;
            }
        }
           
    }

    public static void ViewMedical(InsuranceStorage storage)
    {
        storage.DisplayMedicalList();
    }

    public static void ViewDental(InsuranceStorage storage)
    {
        storage.DisplayDentalList();
    }

    public static void ViewVision(InsuranceStorage storage)
    {
        storage.DisplayVisionList();
    }

    public static void ViewLife(InsuranceStorage storage)
    {
        storage.DisplayLifeList();
    }
    public static void ViewHousing(InsuranceStorage storage)
    {
        storage.DisplayHousingList();
    }
    public static void ViewRental(InsuranceStorage storage)
    {
        storage.DisplayRentalList();
    }
    public static void ViewCar(InsuranceStorage storage)
    {
        storage.DisplayCarList();
    }
}