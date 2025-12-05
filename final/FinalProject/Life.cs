public class Life : Insurance
{
    private List<string> _coverage;
    private double _payout;

    public Life(string insuranceName, string insuranceDescription, double monthlyCost, string memberID, int groupNumber, List<string> coverage, double payout) : base(insuranceName, insuranceDescription, monthlyCost, memberID)
    {
        this._coverage = coverage;
        this._payout = payout;
    }
    public override void DisplayInsurance()
    {

    }

    public override void SaveToFile()
    {

    }

    public override void LoadFromFile()
    {
        
    }
    
}