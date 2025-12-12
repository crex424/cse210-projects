using System.Net;

public class Insurance
{
    private string _insuranceName;
    private string _insuranceDescription;
    private double _monthlyCost;

    public Insurance(string insuranceName, string insuranceDescription, double monthlyCost)
    {
        this._insuranceName = insuranceName;
        this._insuranceDescription = insuranceDescription;
        this._monthlyCost = monthlyCost;
    }

    public virtual void DisplayInsurance()
    {
        Console.WriteLine($"{_insuranceName} {_insuranceDescription} {_monthlyCost}");
    }

    public string GetName()
    {
        return _insuranceName;
    }

    public string GetDescription()
    {
        return _insuranceDescription;
    }

    public double GetMonthlyCost()
    {
        return _monthlyCost;
    }

    public virtual void SaveToFile()
    {

    }

    public virtual void LoadFromFile()
    {
        
    }
}