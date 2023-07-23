



CarDealer dealer = new CarDealer();

Consumer Michael = new Consumer("Michael");
Consumer Sebastian = new Consumer("Sebastian");


dealer.NewCarInfo += Michael.NewCarIsHere;
dealer.NewCar("Ferrari");
Console.WriteLine();

dealer.NewCarInfo += Sebastian.NewCarIsHere;
dealer.NewCar("Mercedes");
Console.WriteLine();

dealer.NewCarInfo -= Michael.NewCarIsHere;
dealer.NewCar("Red Bull Racing");

Console.ReadKey();





public class CarInfoEventArgs : EventArgs
{
    public string Car { get; private set; }
    public CarInfoEventArgs(string car)
    {
        this.Car = car;
    }
}

public class CarDealer
{
    public event EventHandler<CarInfoEventArgs> NewCarInfo;

    public void NewCar(string car)
    {
        Console.WriteLine("Автосалон, новый автомобиль {0}", car);
        RaiseNewCarInfo(car);
    }

    protected virtual void RaiseNewCarInfo(string car)
    {
        EventHandler<CarInfoEventArgs> newCarlnfo = NewCarInfo;
        if (newCarlnfo != null)
        {
            newCarlnfo(this, new CarInfoEventArgs(car));
        }
    }
}

public class Consumer
{
    private string name;

    public Consumer(string name)
    {
        this.name = name;
    }

    public void NewCarIsHere(object sender, CarInfoEventArgs e)
    {
        Console.WriteLine("{0} : Автомобиль {1} новый", name, e.Car);
    }
}

