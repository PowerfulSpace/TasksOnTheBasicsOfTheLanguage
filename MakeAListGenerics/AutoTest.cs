//Список должен быть обобщённый



class AutoTest<S, I, D, B> : IComparable<AutoTest<S, I, D, B>> where D: struct
{
    private S carname;
    private I maxspeed;
    private D cost;
    private B discount;
    private I id;



    public AutoTest() { }
    public AutoTest(S CarName, I MaxSpeed, D cost, B discount, I ID)
    {
        Carname = CarName;
        Maxspeed = MaxSpeed;
        Cost = cost;
        Discount = discount;
        Id = ID;
    }


    public S Carname
    {
        get { return carname; }
        set { carname = value; }
    }

    public I Maxspeed
    {
        get { return maxspeed; }
        set { maxspeed = value; }
    }

    public D Cost
    {
        get { return cost; }
        set { cost = value; }
    }

    public B Discount
    {
        get { return discount; }
        set { discount = value; }
    }

    public I Id
    {
        get { return id; }
        set { id = value; }
    }

    public int CompareTo(AutoTest<S, I, D, B>? other)
    {
        return this.CompareTo(other);
    }

    public override string ToString()
    {
        return String.Format("{0}\tМарка: {1}\tМакс. скорость: {2}\tЦена: {3:C}\tСкидка: {4}%",
            Id, Carname, Maxspeed, Cost, Discount);
    }
}


