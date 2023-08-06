
using System.Reflection;




Console.SetWindowSize(80, 45);

var myClass = new Class1(34);

ListVariosStats(myClass);
ListMethods(myClass);
ListFields(myClass);
ListProps(myClass);
ListInterfaces(myClass);
ListConstructors(myClass);

Console.WriteLine(new string('-', 60));
Type type = myClass.GetType();

MethodInfo methodC = type.GetMethod("MethodC", BindingFlags.Instance | BindingFlags.NonPublic);
methodC.Invoke(myClass, new object[] { "Hello", " world!" });

FieldInfo mystring = type.GetField("mystring", BindingFlags.Instance | BindingFlags.NonPublic);
mystring.SetValue(myClass, "Привет Мир!");

Console.WriteLine(myClass.MyString);

//Вызов метода из свойства 
MethodInfo getPropMethod = type.GetMethod("get_myProp");
Console.WriteLine(getPropMethod.Invoke(myClass, null));








Console.ReadLine();


static void ListVariosStats(Class1 cl)
{
    Console.WriteLine(new string('_', 30) + " Информация о Class1" + "\n");
    Type t = cl.GetType();

    Console.WriteLine("Полное Имя:             {0}", t.FullName);
    Console.WriteLine("Базовый класс:          {0}", t.BaseType);
    Console.WriteLine("Абстрактный:            {0}", t.IsAbstract);
    Console.WriteLine("Запрещено наследование: {0}", t.IsSealed);
    Console.WriteLine("Это class:              {0}", t.IsClass);
}

static void ListMethods(Class1 cl)
{
    Console.WriteLine(new string('_', 30) + " Методы класса Class1" + "\n");

    Type t = cl.GetType();
    MethodInfo[] mi = t.GetMethods(BindingFlags.Instance
            | BindingFlags.Static
            | BindingFlags.Public
            | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);

    foreach (MethodInfo m in mi)
        Console.WriteLine("Method: {0}", m.Name);
}

static void ListFields(Class1 cl)
{
    Console.WriteLine(new string('_', 30) + " Поля класса Class1" + "\n");

    Type t = cl.GetType();
    FieldInfo[] fi =
        t.GetFields(BindingFlags.Instance
            | BindingFlags.Static
            | BindingFlags.Public
            | BindingFlags.NonPublic);

    foreach (FieldInfo f in fi)
        Console.WriteLine("Field: {0}", f.Name);
}

static void ListProps(Class1 cl)
{
    Console.WriteLine(new string('_', 30) + " Свойства класса Class1" + "\n");

    Type t = cl.GetType();
    PropertyInfo[] pi = t.GetProperties();

    foreach (PropertyInfo p in pi)
        Console.WriteLine("Свойство: {0}", p.Name);
}

static void ListInterfaces(Class1 cl)
{
    Console.WriteLine(new string('_', 30) + " Интерфейсы класса Class1" + "\n");

    Type t = cl.GetType();

    Type[] it = t.GetInterfaces();

    foreach (Type i in it)
        Console.WriteLine("Интерфейс: {0}", i.Name);
}

static void ListConstructors(Class1 cl)
{
    Console.WriteLine(new string('_', 30) + " Конструкторы класса Class1" + "\n");
    // Все ли конструкторы отобразились???
    Type t = cl.GetType();
    ConstructorInfo[] ci = t.GetConstructors();

    foreach (ConstructorInfo m in ci)
        Console.WriteLine("Constructor: {0}", m.Name);
}




public interface IInterface1
{
    void MethodA();
}
public interface IInterface2
{
    void MethodB();
}

public class Class1 : IInterface1, IInterface2
{
    public int myint;
    private string mystring = "Hello";

    static Class1() { }
    public Class1() { }
    public Class1(int i)
    {
        this.myint = i;
    }

    public int MyProp { get; set; }

    public int myProp
    {
        get { return myint; }
        set { myint = value; }
    }

    public string MyString
    {
        get { return mystring; }
    }

    public void MethodA() { }
    public void MethodB() { }

    private void MethodC(string str, string str2)
    {
        Console.WriteLine(str + str2);
    }
    public void myMethod(int p1, string p2) { }
}








