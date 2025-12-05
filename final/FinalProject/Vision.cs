public class Vision : Insurance
{
    private int _groupNumber;

    public Vision(string insuranceName, string insuranceDescription, double monthlyCost, string memberID, int groupNumber) : base(insuranceName, insuranceDescription, monthlyCost, memberID)
    {
        this._groupNumber = groupNumber;
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