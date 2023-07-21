//Список должен быть обобщённый



public class Auto
{
    private string carname;
    private int maxspeed;
    private double cost;
    private byte discount;
    private int id;

    public string Carname
    {
        get { return carname; }
        set { carname = value; }
    }

    public int Maxspeed
    {
        get { return maxspeed; }
        set { maxspeed = value; }
    }

    public double Cost
    {
        get { return cost; }
        set { cost = value; }
    }

    public byte Discount
    {
        get { return discount; }
        set { discount = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public Auto() { }
    public Auto(string CarName, int MaxSpeed, double cost, byte discount, int ID)
    {
        Carname = CarName;
        Maxspeed = MaxSpeed;
        Cost = cost;
        Discount = discount;
        Id = ID;
    }

    public override string ToString()
    {
        return String.Format("{0}\tМарка: {1}\tМакс. скорость: {2}\tЦена: {3:C}\tСкидка: {4}%",
            Id, Carname, Maxspeed, Cost, Discount);
    }
}
