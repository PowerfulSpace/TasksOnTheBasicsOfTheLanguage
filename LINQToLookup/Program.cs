


var racers = new List<Racer>();
racers.Add(new Racer(1, "Jacques", "Villeneuve", "Canada", 11));
racers.Add(new Racer(2, "Alan", "Jones", "Australia", 12));
racers.Add(new Racer(3, "Jackie", "Stewart", "United Kingdom", 27));
racers.Add(new Racer(4, "James", "Hunt", "United Kingdom", 10));
racers.Add(new Racer(5, "Jack", "Brabham", "Australia", 14));
var lookupRacers = racers.ToLookup(r => r.Country);
foreach (Racer r in lookupRacers["Australia"])
{
    Console.WriteLine(r);
}

Console.ReadKey();


public class Racer : IComparable<Racer>
{
    public int Id { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Wins { get; set; }
    public string Country { get; set; }

    public Racer(int id, string firstName, string lastName, string country)
        : this(id, firstName, lastName, country, wins: 0)
    {
    }

    public Racer(int id, string firstName, string lastName, string country, int wins)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Country = country;
        this.Wins = wins;
    }

    public override string ToString()
    {
        return String.Format("{0} {1}", FirstName, LastName);
    }

    public int CompareTo(Racer other)
    {
        if (other == null) return -1;
        int compare = string.Compare(this.LastName, other.LastName);
        if (compare == 0)
            return string.Compare(this.FirstName, other.FirstName);
        return compare;
    }
}


