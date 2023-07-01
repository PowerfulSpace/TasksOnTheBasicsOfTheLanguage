

//1.1 Разработать один из классов, в соответствии с полученным вариантом.
//1.2 Реализовать не менее пяти закрытых полей (различных типов), представляющих
//  основные характеристики рассматриваемого класса. 
//1.3 Создать не менее трех методов управления классом и методы доступа к его закрытым полям. 
//1.4 Создать метод, в который передаются аргументы по ссылке. 
//1.5 Создать не менее двух статических полей (различных типов),
//  представляющих общие характеристики объектов данного класса.
//1.6 Обязательным требованием является реализация нескольких перегруженных конструкторов,
//  аргументы которых определяются студентом, исходя из специфики реализуемого класса,
//  а так же реализация конструктора по умолчанию.
//1.7 Создать статический конструктор. 
//1.8 Создать массив (не менее 5 элементов) объектов созданного класса. 
//1.9 Создать дополнительный метод для данного класса в другом файле, используя ключевое слово partial.




Car[] cars = new Car[5];

cars[0] = new Car("bmw");
cars[1] = new Car("mersedes");
cars[2] = new Car("audi");
cars[3] = new Car("lada");
cars[4] = new Car("opel");



partial class Car
{
    private string brand;
    private decimal price;
    private int speed;
    private bool leftHandDrive;
    private double engine;

    static string color;
    static double TireSize;

    public Car()
    {

    }
    static Car()
    {

    }
    public Car(string brand)
    {

    }
    public Car(string brand, decimal price, int speed, bool leftHandDrive = false, double engine = 0)
    {
        this.brand = brand;
        this.price = price;
        this.speed = speed;
        this.leftHandDrive = leftHandDrive;
        this.engine = engine;
    }

   


    public string Brand { get => brand; set => brand = value; }
    public decimal Price { get => price; set => price = value; }
    public int Speed { get => speed; set => speed = value; }
    public bool LeftHandDrive { get => leftHandDrive; set => leftHandDrive = value; }
    public double Engine { get => engine; set => engine = value; }

    public void Show()
    {
        string leftHandDriveCar = LeftHandDrive ? "леворульной" : "праворульной";
        Console.WriteLine($"Автомобиль: {Brand}, цена: {Price}, скорость: {Speed}, двигатель: {Engine}, является: {leftHandDriveCar}");
    }

    public int GetPrice()
    {
        return Speed;
    }

    public int TestDrive(ref int km)
    {
        return Speed * km;
    }
    public partial string GetColor();
}



partial class Car
{
    public partial string GetColor()
    {
        return color;
    }
}







