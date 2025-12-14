using System;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<string> life_cov = new List<string>();
        life_cov.Add("Health related death");
        life_cov.Add("Vehicular related death");
        life_cov.Add("Murder related death");
        life_cov.Add("Weather related death");
        List<string> house_cov = new List<string>();
        house_cov.Add("Weather");
        house_cov.Add("Break in");
        house_cov.Add("Rot");
        List<string> car_cov = new List<string>();
        car_cov.Add("Weather");
        car_cov.Add("Break in");
        car_cov.Add("Accident");
        car_cov.Add("Robbery");

        Medical med = new Medical("Blue Cross", "Insurance for government employees that covers most health issues", 300.12);
        Medical med2 = new Medical("Skeleton Co", "Insurance that is focused of bones", 240.22);
        Dental dent = new Dental("Dental Insurance", "Given to workers part of Hello corp which covers operations on teeth.", 120.00);
        Vision vision = new Vision("Eye Care", "Covers your eye care such as glasses.", 70.66);
        Life life = new Life("You Die We Pay", "Provides a payout to your family if you die.", 200.00, life_cov, 100000);
        Housing housing = new Housing("Farmers", "We are farmers, buh buh ban buh buh buh.", 113.00, house_cov, 45.99);
        Rental rent = new Rental("Progressive", "Covers rent adjacent issues such as damage to your property.", 15.99);
        Car car = new Car("Progressive", "Covers damage to your car, and replacement funds for totaled.", 120.65, car_cov);

        InsuranceStorage storage = new InsuranceStorage();
        storage.AddMedical(med);
        storage.AddMedical(med2);
        storage.AddDental(dent);
        storage.AddVision(vision);
        storage.AddLife(life);
        storage.AddHousing(housing);
        storage.AddRental(rent);
        storage.AddCar(car);
        int user_choice = 0;
        while (user_choice != 8)
        {
            Console.WriteLine("In this program you will be able to view different types of insurances and their particular companies and see which people are currently enrolled in it.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1: View Medical Insurance");
            Console.WriteLine("   2: View Dental Insurance");
            Console.WriteLine("   3: View Vision Insurance");
            Console.WriteLine("   4: View Life Insurance");
            Console.WriteLine("   5: View Housing Insurance");
            Console.WriteLine("   6: View Rental Insurance");
            Console.WriteLine("   7: View Car Insurance");
            Console.WriteLine("   8: Quit");
            Console.Write("> ");
            user_choice = int.Parse(Console.ReadLine());
            switch (user_choice)
            {
                case 1:
                    Console.Clear();
                    ViewMedical(storage);
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    ViewDental(storage);
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    ViewVision(storage);
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    ViewLife(storage);
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    ViewHousing(storage);
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    ViewRental(storage);
                    Console.Clear();
                    break;
                case 7:
                    Console.Clear();
                    ViewCar(storage);
                    Console.Clear();
                    break;
            }
        }

    }

    public static void ViewMedical(InsuranceStorage storage)
    {
        storage.DisplayMedicalList();
        Console.WriteLine("Press any button to continue.");
        Console.ReadLine();
    }

    public static void ViewDental(InsuranceStorage storage)
    {
        storage.DisplayDentalList();
        Console.WriteLine("Press any button to continue.");
        Console.ReadLine();
    }

    public static void ViewVision(InsuranceStorage storage)
    {
        storage.DisplayVisionList();
        Console.WriteLine("Press any button to continue.");
        Console.ReadLine();
    }

    public static void ViewLife(InsuranceStorage storage)
    {
        storage.DisplayLifeList();
        Console.WriteLine("Press any button to continue.");
        Console.ReadLine();
    }
    public static void ViewHousing(InsuranceStorage storage)
    {
        storage.DisplayHousingList();
        Console.WriteLine("Press any button to continue.");
        Console.ReadLine();
    }
    public static void ViewRental(InsuranceStorage storage)
    {
        storage.DisplayRentalList();
        Console.WriteLine("Press any button to continue.");
        Console.ReadLine();
    }
    public static void ViewCar(InsuranceStorage storage)
    {
        storage.DisplayCarList();
        Console.WriteLine("Press any button to continue.");
        Console.ReadLine();
    }
}