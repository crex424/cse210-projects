public class InsuranceStorage
{
    private List<Medical> _medical = new List<Medical>();
    private List<Vision> _vision = new List<Vision>();
    private List<Dental> _dental = new List<Dental>();
    private List<Life> _life = new List<Life>();
    private List<Housing> _housing = new List<Housing>();
    private List<Rental> _rental = new List<Rental>();
    private List<Car> _car = new List<Car>();

    public InsuranceStorage()
    {

    }

    public void AddMedical(Medical new_med)
    {
        _medical.Add(new_med);
    }

    public void AddVision(Vision new_vis)
    {
        _vision.Add(new_vis);
    }

    public void AddDental(Dental new_dent)
    {
        _dental.Add(new_dent);
    }

    public void AddLife(Life new_life)
    {
        _life.Add(new_life);
    }

    public void AddHousing(Housing new_house)
    {
        _housing.Add(new_house);
    }

    public void AddRental(Rental new_rent)
    {
        _rental.Add(new_rent);
    }

    public void AddCar(Car new_car)
    {
        _car.Add(new_car);
    }

    public void DisplayMedicalList()
    {
        foreach (Medical med in _medical)
        {
            med.DisplayInsurance();
        }
    }

    public void DisplayVisionList()
    {
        foreach (Vision vis in _vision)
        {
            vis.DisplayInsurance();
        }
    }

    public void DisplayDentalList()
    {
        foreach (Dental dent in _dental)
        {
            dent.DisplayInsurance();
        }
    }

    public void DisplayLifeList()
    {
        foreach (Life life in _life)
        {
            life.DisplayInsurance();
        }
    }

    public void DisplayHousingList()
    {
        foreach (Housing house in _housing)
        {
            house.DisplayInsurance();
        }
    }

    public void DisplayRentalList()
    {
        foreach (Rental rent in _rental)
        {
            rent.DisplayInsurance();
        }
    }

    public void DisplayCarList()
    {
        foreach (Car car in _car)
        {
            car.DisplayInsurance();
        }
    }
}