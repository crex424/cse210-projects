public class Rental : Insurance
{
    private int _policyNumber;

    public Rental(string insuranceName, string insuranceDescription, double monthlyCost, string memberID, int groupNumber, int policyNumber) : base(insuranceName, insuranceDescription, monthlyCost, memberID)
    {
        this._policyNumber = policyNumber;
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