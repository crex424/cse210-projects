public class Insurance
{
    private string _insuranceName;
    private string _insuranceDescription;
    private double _monthlyCost;
    private string _memberID;

    private List<Customer> _customerInfo;


    public Insurance(string insuranceName, string insuranceDescription, double monthlyCost, string memberID)
    {
        this._insuranceName = insuranceName;
        this._insuranceDescription = insuranceDescription;
        this._monthlyCost = monthlyCost;
        this._memberID = memberID;
    }

    public virtual void DisplayInsurance()
    {

    }

    public virtual void SaveToFile()
    {

    }

    public virtual void LoadFromFile()
    {
        
    }
}