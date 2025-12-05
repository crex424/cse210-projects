public class Car : Insurance
{
    private List<string> _coverage;
    private string _model;

    public Car(string insuranceName, string insuranceDescription, double monthlyCost, string memberID, int groupNumber, List<string> coverage, string model) : base(insuranceName, insuranceDescription, monthlyCost, memberID)
    {
        this._coverage = coverage;
        this._model = model;
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