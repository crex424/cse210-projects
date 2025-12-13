public class Housing : Insurance
{
    private List<string> _coverage;
    private double _deductible;

    public Housing(string insuranceName, string insuranceDescription, double monthlyCost, List<string> coverage, double deductible) : base(insuranceName, insuranceDescription, monthlyCost)
    {
        this._coverage = coverage;
        this._deductible = deductible;
    }

    public override void DisplayInsurance()
    {
        Console.WriteLine($"{GetName()}| Description: {GetDescription()}| Cost Per Month: ${GetMonthlyCost()}| deductible: ${_deductible}| coverage:");
        foreach (string coverage in _coverage)
        {
            Console.WriteLine($"   {coverage}");
        }
    }
}