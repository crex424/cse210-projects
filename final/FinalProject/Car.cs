public class Car : Insurance
{
    private List<string> _coverage;

    public Car(string insuranceName, string insuranceDescription, double monthlyCost, List<string> coverage) : base(insuranceName, insuranceDescription, monthlyCost)
    {
        this._coverage = coverage;
    }

    public override void DisplayInsurance()
    {
        Console.WriteLine($"{GetName()} {GetDescription()} Cost Per Month:{GetMonthlyCost()} coverage:");
        foreach (string coverage in _coverage)
        {
            Console.WriteLine($"   {coverage}");
        }
    }

    public override void SaveToFile()
    {

    }

    public override void LoadFromFile()
    {
        
    }
}