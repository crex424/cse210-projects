public class Life : Insurance
{
    private List<string> _coverage;
    private double _payout;

    public Life(string insuranceName, string insuranceDescription, double monthlyCost, List<string> coverage, double payout) : base(insuranceName, insuranceDescription, monthlyCost)
    {
        this._coverage = coverage;
        this._payout = payout;
    }
    public override void DisplayInsurance()
    {
        Console.WriteLine($"{GetName()}| Description: {GetDescription()}| Cost Per Month:{GetMonthlyCost()}| payout: ${_payout}| coverage:");
        foreach (string coverage in _coverage)
        {
            Console.WriteLine($"   {coverage}");
        }
    }
    
}