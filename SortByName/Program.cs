


var collect = new List<Person>
{
  new Person{FirstName = "Damon", LastName = "Hill"},
  new Person{FirstName = "Niki", LastName = "Lauda"},
  new Person{FirstName = "Ayrton", LastName = "Senna"},
  new Person{FirstName = "Graham", LastName = "Hill"},
  new Person{FirstName = "Damon", LastName = "Crauch"}
};

foreach (var item in collect)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n\n\n");

var sorCollect = collect.OrderBy(x => x.FirstName);

foreach (var item in sorCollect)
{
    Console.WriteLine(item);
}

Console.ReadKey();


public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return string.Format("{0} {1}", FirstName, LastName);
    }
}
