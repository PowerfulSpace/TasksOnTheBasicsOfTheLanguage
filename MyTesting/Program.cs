

using System.Reflection;

Console.SetWindowSize(80, 50);

Assembly assembly = null;

try
{
    assembly = Assembly.Load("CarLibrary");
    Console.WriteLine("Сборка CarLibrary - успешно загружена.");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}

ListAllTypes(assembly);
ListAllMembers(assembly);
GetParams(assembly);

Console.ReadKey();


static void ListAllTypes(Assembly assembly)
{
    Console.WriteLine(new string('_', 80));
    Console.WriteLine("\nТипы в: {0} \n", assembly.FullName);

    Type[] types = assembly.GetTypes();

    foreach (Type t in types)
        Console.WriteLine("Тип: {0}", t);
}

static void ListAllMembers(Assembly assembly)
{
    Console.WriteLine(new string('_', 80));

    Type type = assembly.GetType("CarLibrary.MiniVan");

    Console.WriteLine("\nЧлены класса: {0} \n", type);

    MemberInfo[] members = type.GetMembers();

    foreach (MemberInfo element in members)
        Console.WriteLine("{0,-15}:  {1}", element.MemberType, element);
}

static void GetParams(Assembly assembly)
{
    Console.WriteLine(new string('_', 80));

    Type type = assembly.GetType("CarLibrary.MiniVan");
    MethodInfo method = type.GetMethod("Driver");

    Console.WriteLine("\nИнформация о параметрах для метода {0}", method.Name);
    ParameterInfo[] parameters = method.GetParameters();
    Console.WriteLine("Метод имеет " + parameters.Length + " параметров");

    foreach (ParameterInfo parameter in parameters)
    {
        Console.WriteLine("Имя параметра: {0}", parameter.Name);
        Console.WriteLine("Позиция в методе: {0}", parameter.Position);
        Console.WriteLine("Тип параметра: {0}", parameter.ParameterType);
    }

}




public abstract class Car
{
    protected string name;
    protected short currentSpeed;
    protected short maxSpeed;
    protected EngineState state;


    protected Car()
    {
        state = EngineState.EngineAlive;
    }

    protected Car(string name, short maxSpeed, short currentSpeed)
        : this()
    {
        this.name = name;
        this.maxSpeed = maxSpeed;
        this.currentSpeed = currentSpeed;
    }


    public abstract void Acceleration();

    public void Driver(string name, int age)
    {
        Console.WriteLine("Имя водителя: {0}. Возраст: {1}", name, age);
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public short CurrentSpeed
    {
        get { return currentSpeed; }
        set { currentSpeed = value; }
    }

    public short MaxSpeed
    {
        get { return maxSpeed; }
    }

    public EngineState EngineState
    {
        get { return state; }
    }
}

public enum EngineState
{
    EngineAlive,
    EngineDead
}

public class MiniVan : Car
{
    public MiniVan()
    {
    }

    public MiniVan(string name, short maxSpeed, short currentSpeed)
        : base(name, maxSpeed, currentSpeed)
    {
    }

    public override void Acceleration()
    {
        state = EngineState.EngineDead;
        Console.WriteLine("MINIVAN:  Двигатель сгорел!");
    }
}


public class SportsCar : Car
{
    public SportsCar()
    {
    }

    public SportsCar(string name, short maxSpeed, short currentSpeed)
        : base(name, maxSpeed, currentSpeed)
    {
    }

    public override void Acceleration()
    {
        Console.WriteLine("SPORTCAR:  Быстрая скорость!");

    }
}

internal class SecretCar : Car
{
    public override void Acceleration()
    {
        throw new NotImplementedException();
    }
}
