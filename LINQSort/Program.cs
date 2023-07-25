


var employees = new List<Employee>
            {
                new Employee {LastName = "Ivanov", FirstName = "Ivan", Nationality = "Russian"},
                new Employee {LastName = "Andreev", FirstName = "Andrew", Nationality = "Ukrainian"},
                new Employee {LastName = "Petrov", FirstName = "Petr", Nationality = "American"},
                new Employee {LastName = "Petrov", FirstName = "Boris", Nationality = "American"},
                new Employee {LastName = "Sidorov", FirstName = "Aleksei", Nationality = "Russian"}
            };

var query = from emp in employees
            orderby emp.Nationality ascending,
            emp.LastName descending,
            emp.FirstName descending
            select emp;

foreach (var person in query)
    Console.WriteLine("{0}, {1}, {2}", person.LastName, person.FirstName, person.Nationality);

Console.ReadKey();








public class Employee
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Nationality { get; set; }
}
