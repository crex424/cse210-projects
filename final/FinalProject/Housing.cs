public class Housing : Insurance
{
    private List<string> _coverage;
    private int _deductible;

    public Housing(string insuranceName, string insuranceDescription, double monthlyCost, string memberID, int groupNumber, List<string> coverage, int deductible) : base(insuranceName, insuranceDescription, monthlyCost, memberID)
    {
        this._coverage = coverage;
        this._deductible = deductible;
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