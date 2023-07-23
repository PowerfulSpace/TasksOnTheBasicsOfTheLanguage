



Employee[] employees =
{
                new Employee("Bugs Bunny", 20000m),
                new Employee("Elmer Fudd", 10000m),
                new Employee("Daffy Duck", 25000m),
                new Employee("Wile Coyote", 1000000.38m),
                new Employee("Foghorn Leghorn", 23000m),
                new Employee("RoadRunner", 50000m)
            };

BubbleSorter.Sort<Employee>(employees, Employee.CompareSalary);

foreach (var employee in employees)
{
    Console.WriteLine(employee);
}

Console.ReadLine();





class Employee
{
    public Employee(string name, decimal salary)
    {
        this.Name = name;
        this.Salary = salary;
    }
    public string Name { get; private set; }
    public decimal Salary { get; private set; }
    public override string ToString()
    {
        return string.Format("{0}, {1}", Name, Salary);
    }
    public static bool CompareSalary(Employee el, Employee e2)
    {
        return el.Salary < e2.Salary;
    }
}



class BubbleSorter
{
    static public void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparison)
    {
        bool swapped = true;
        do
        {
            swapped = false;
            for (int i = 0; i < sortArray.Count - 1; i++)
            {
                if (comparison(sortArray[i + 1], sortArray[i]))
                {
                    T temp = sortArray[i];
                    sortArray[i] = sortArray[i + 1];
                    sortArray[i + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
    }
}
